
using FastFoodSystem;
using FastFoodSystem.ManagmentSystem.Entities;
using FastFoodSystem.ManagmentSystem.Forms;
using FastFoodSystem.OrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.WebRequestMethods;


namespace CompleteSystem.ManagmentSystem.Forms
{

    public partial class InitialForm : Form
    {

        public List<PoruchkaEntity> filteredOrders { get; set; }



        public InitialForm()
        {
            InitializeComponent();
            InitializeLineDayChart();
            InitializeLineWeekChart();
            InitializedLineMounthChart();
            InitializePieSizeChart();
            InitializePieSouceChart();
            InitializePiePastaChart();
            ViewReviziqElements();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            PoruchkiFLP.FlowDirection = FlowDirection.TopDown; // Arrange buttons vertically
            PoruchkiFLP.AutoScroll = true;
            PoruchkiFLP.WrapContents = false;
            InitializeDostavchiciComboBox();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
        }


        private void showItems(object sender, EventArgs e)
        {
            ItemsKumPoruchkaListBox.Items.Clear();
            using (var db = new OrderDbContext())
            {
                List<ItemEntity> items = db.Items.Where(x => x.PoruchkaId == ((Button)sender).TabIndex).ToList();
                foreach (var item in items)
                {
                    ItemsKumPoruchkaListBox.Items.Add($"{item.Name} - {item.Quantity}бр. цена: {item.Price * item.Quantity:F2}лв.");
                }
            }



        }

        private void DisplayPastaSalesByHour(IEnumerable<dynamic> pastaSalesByHour)
        {
            // Изчистване на старите резултати
            listBox.Items.Clear();

            // Показване на новите резултати
            foreach (var salesData in pastaSalesByHour)
            {
                listBox.Items.Add($"{salesData.Hour}: Продадени пасти: {salesData.PastaCount}");
            }
        }
        private void NazadBtn1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
        private void VijPoruchki_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            using (var db = new OrderDbContext())
            {
                if (startDate == endDate)
                {

                    filteredOrders = db.Poruchki
                   .Where(o => o.OrderDate.Year == startDate.Year &&
                    o.OrderDate.Month == startDate.Month &&
                    o.OrderDate.Day == startDate.Day)
                    .ToList();
                }
                else
                {
                    // Otherwise, filter orders based on the date range
                    DateTime endDatePlusOneDay = endDate.AddDays(1);
                    filteredOrders = db.Poruchki
                        .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDatePlusOneDay)
                        .ToList();
                }
            }

            PoruchkiFLP.Controls.Clear();

            foreach (var order in filteredOrders.OrderByDescending(x => x.OrderDate))
            {
                Button button = new Button();
                button.AutoSize = true;
                button.Font = new Font("Arial", 25);
                button.Text = $"{order.Id} - {order.OrderDate.ToShortDateString()} - {order.Price:F2}лв.";
                button.Click += showItems;
                button.TabIndex = order.Id;
                PoruchkiFLP.Controls.Add(button);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////
        private DateTime GetStartDateOfWeek(int weekOfYear)
        {
            DateTime jan1 = new DateTime(DateTime.Now.Year, 1, 1);
            int daysOffset = DayOfWeek.Monday - jan1.DayOfWeek;
            DateTime firstMonday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstMonday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            if (firstWeek <= 1)
            {
                weekNum -= 1;
            }
            var result = firstMonday.AddDays(weekNum * 7);

            return result;
        }
        private DateTime GetEndDateOfWeek(int weekOfYear)
        {
            var startDate = GetStartDateOfWeek(weekOfYear);
            var endDate = startDate.AddDays(6); // Седмицата завършва след 6 дни

            return endDate;
        }
        private void Priloji_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker.Value.Date;
            DateTime startTime = selectedDate.AddHours(7); // Първият час е 10:00
            DateTime endTime = selectedDate.AddHours(22); // Последният час е 22:00

            using (var dbContext = new OrderDbContext()) // Използвайте using с контекста на базата данни
            {
                var poruchkiFiltered = dbContext.Poruchki
                    .Where(p => p.OrderDate >= startTime && p.OrderDate <= endTime) // Филтрираме поръчките по дата
                    .ToList(); // Превключваме към работа с колекция на клиента

                var pastaItems = dbContext.Items
                    .Where(item => item.Type == "Pasta") // Филтрираме само пастите
                    .ToList(); // Превключваме към работа с колекция на клиента

                var pastaSalesByHour = poruchkiFiltered
                   .SelectMany(p => pastaItems
                       .Where(item => item.PoruchkaId == p.Id)
                       .Select(item => new { Poruchka = p, Item = item })) // Свързваме поръчките с елементите
                   .GroupBy(itemPair => (itemPair.Poruchka.OrderDate - startTime).Hours) // Групираме по разликата в часове
                   .Select(g => new
                   {
                       Hour = startTime.AddHours(g.Key).ToString("HH:mm"),
                       PastaCount = g.Sum(item => item.Item.Quantity)
                   })
                   .OrderBy(p => p.Hour)
                   .ToList();

                DisplayPastaSalesByHour(pastaSalesByHour);
            }
        }
        private void InitializeLineDayChart()
        {
            // Create a new series for the chart
            Series dayLineSeries = new Series("Total Sales");
            dayLineSeries.ChartType = SeriesChartType.Line;

            // Connect to your Entity Framework context
            using (var dbContext = new OrderDbContext())
            {
                var oneMonthAgo = DateTime.Now.AddMonths(-1); // Получаваме датата преди един месец от сегашната дата

                var salesByDate = dbContext.Poruchki
                    .Where(p => p.OrderDate >= oneMonthAgo) // Филтрираме само поръчките, направени в последния месец
                    .AsEnumerable() // Прехвърляме обработката на данните към C# след извличане на всички данни
                    .GroupBy(p => p.OrderDate.Date) // Групираме по дата (без време)
                    .Select(g => new
                    {
                        Date = g.Key,
                        TotalSales = g.Sum(p => p.Price) // Изчисляваме общата сума за всяка дата
                    })
                    .OrderBy(s => s.Date)
                    .ToList();

                foreach (var sale in salesByDate)
                {
                    dayLineSeries.Points.AddXY(sale.Date, sale.TotalSales);
                }
            }
            DaysLinechart.Series.Add(dayLineSeries);

            // Set chart title and axis labels
            DaysLinechart.Titles.Add("Total Sales by Date");
            DaysLinechart.ChartAreas[0].AxisX.Title = "Date";
            DaysLinechart.ChartAreas[0].AxisY.Title = "Total Sales";
            // Add the series to the chart
            AddThingsToChart(DaysLinechart);
        }
        private void InitializeLineWeekChart()
        {
            // Create a new series for the chart
            Series weekLineSeries = new Series("Total Sales");
            weekLineSeries.ChartType = SeriesChartType.Line;

            // Connect to your Entity Framework context
            using (var dbContext = new OrderDbContext())
            {
                var startDate = DateTime.Now.AddDays(-63); // Получаваме датата преди 9 седмици от сегашната дата

                var salesByWeek = dbContext.Poruchki
                    .Where(p => p.OrderDate >= startDate) // Филтрираме поръчките, направени в последните 9 седмици
                    .AsEnumerable() // Прехвърляме обработката на данните към C# след извличане на всички данни
                    .GroupBy(p => CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(p.OrderDate, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)) // Групираме по номер на седмица
                    .Select(g => new
                    {
                        WeekStartDate = GetStartDateOfWeek(g.Key),
                        WeekEndDate = GetEndDateOfWeek(g.Key),
                        TotalSales = g.Sum(p => p.Price) // Изчисляваме общата сума за всяка седмица
                    })
                    .OrderBy(s => s.WeekStartDate)
                    .ToList();

                foreach (var sale in salesByWeek)
                {
                    // Форматиране на текста за представяне на периода на седмицата
                    var weekPeriod = $"{sale.WeekStartDate.ToString("d.MM")} - {sale.WeekEndDate.ToString("d.MM")}";

                    // Тук вместо weekLineSeries трябва да ползвате същия обект, който ползвате за диаграмата, за да добавите точките.
                    weekLineSeries.Points.AddXY(weekPeriod, sale.TotalSales);
                }
            }

            // Метод за изчисляване на началната дата на седмицата


            WeeksLineChart.Series.Add(weekLineSeries);
            WeeksLineChart.Titles.Add("Total Sales by Date");
            WeeksLineChart.ChartAreas[0].AxisX.Title = "Date";
            WeeksLineChart.ChartAreas[0].AxisY.Title = "Total Sales";
            // Add the series to the chart
            AddThingsToChart(WeeksLineChart);
        }
        private void InitializedLineMounthChart()
        {
            Series mounthLineSeries = new Series("Total Sales");
            mounthLineSeries.ChartType = SeriesChartType.Line;

            // Connect to your Entity Framework context
            using (var dbContext = new OrderDbContext())
            {
                var startDate = DateTime.Now.AddMonths(-11); // Получаваме датата преди 11 месеца от сегашната дата

                var salesByMonth = dbContext.Poruchki
                    .Where(p => p.OrderDate >= startDate) // Филтрираме поръчките, направени в последните 12 месеца
                    .AsEnumerable() // Прехвърляме обработката на данните към C# след извличане на всички данни
                    .GroupBy(p => new { Year = p.OrderDate.Year, Month = p.OrderDate.Month }) // Групираме по година и месец
                    .Select(g => new
                    {
                        MonthStartDate = new DateTime(g.Key.Year, g.Key.Month, 1), // Началната дата на месеца
                        MonthEndDate = new DateTime(g.Key.Year, g.Key.Month, DateTime.DaysInMonth(g.Key.Year, g.Key.Month)), // Крайната дата на месеца
                        TotalSales = g.Sum(p => p.Price) // Изчисляваме общата сума за всеки месец
                    })
                    .OrderBy(s => s.MonthStartDate)
                    .ToList();

                foreach (var sale in salesByMonth)
                {
                    // Форматиране на текста за представяне на периода на месеца
                    var monthPeriod = $"{sale.MonthStartDate.ToString("d.MM.yyyy")} - {sale.MonthEndDate.ToString("d.MM.yyyy")}";

                    // Тук вместо weekLineSeries трябва да ползвате същия обект, който ползвате за диаграмата, за да добавите точките.
                    mounthLineSeries.Points.AddXY(monthPeriod, sale.TotalSales);
                }
            }
            MounthsLineChart.Series.Add(mounthLineSeries);

            // Set chart title and axis labels
            MounthsLineChart.Titles.Add("Total Sales by Date");
            MounthsLineChart.ChartAreas[0].AxisX.Title = "Date";
            MounthsLineChart.ChartAreas[0].AxisY.Title = "Total Sales";
            // Add the series to the chart
            AddThingsToChart(MounthsLineChart);
        }
        public void AddThingsToChart(Chart chart)
        {
            chart.MouseMove += (sender, e) =>
            {
                var pos = e.Location;
                var results = chart.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);

                // Проверяваме дали мишката е върху точка на данните
                if (results.Any(result => result.ChartElementType == ChartElementType.DataPoint))
                {
                    var chartArea = chart.ChartAreas[0];

                    // Преобразуваме координатите на мишката в координати на графиката
                    var xValue = chartArea.AxisX.PixelPositionToValue(pos.X);
                    var yValue = chartArea.AxisY.PixelPositionToValue(pos.Y);

                    // Изчистваме старите анотации
                    chart.Annotations.Clear();

                    // Добавяме нова анотация на текущите координати на мишката
                    var annotation = new TextAnnotation
                    {
                        X = xValue,
                        Y = yValue,
                        Text = $"Total Sales: {yValue:F2}",
                        AxisX = chartArea.AxisX,
                        AxisY = chartArea.AxisY
                    };
                    chart.Annotations.Add(annotation);
                }
                else
                {
                    // Изчистваме анотациите ако мишката не е върху точка на данните
                    chart.Annotations.Clear();
                }
            };
        }
        public void InitializePieSizeChart()
        {
            // Извличане на броя на средните и големите елементи от базата данни
            using (var dbContext = new OrderDbContext())
            {
                var mediumItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Средни"))
               .Sum(i => i.Quantity);

                var largeItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Големи"))
               .Sum(i => i.Quantity);

                //Изчисляване на процентното съотношение
                double total = mediumItemsCount + largeItemsCount;
                double mediumPercentage = (mediumItemsCount / total) * 100;
                double largePercentage = (largeItemsCount / total) * 100;

                // Създаване на кръговата диаграма
                RazmerPieChart.Series.Clear();
                RazmerPieChart.Series.Add("Артикули");
                RazmerPieChart.Series["Артикули"].Points.AddXY("Среден", mediumPercentage);
                RazmerPieChart.Series["Артикули"].Points.AddXY("Голям", largePercentage);
                RazmerPieChart.Series["Артикули"].ChartType = SeriesChartType.Pie;


                RazmerPieChart.Legends.Clear();
                RazmerPieChart.Legends.Add(new Legend("АртикулиLegend"));
                RazmerPieChart.Series["Артикули"].Legend = "АртикулиLegend";
                RazmerPieChart.Series["Артикули"].IsVisibleInLegend = true;
                RazmerPieChart.Series["Артикули"].Label = "#PERCENT{P0}";
                List<string> sectorNames = new List<string>() { "среден", "голям" };
                List<int> itemCounts = new List<int>() { mediumItemsCount, largeItemsCount }; // Използвайте стойностите, които имате за конкретната диаграма

                // Извикване на метода с подадените данни
                AddAnnotationToChart<Chart>(RazmerPieChart, sectorNames, itemCounts);
            }
        }
        public void InitializePieSouceChart()
        {
            // Извличане на броя на средните и големите елементи от базата данни
            using (var dbContext = new OrderDbContext())
            {
                var bologneseItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Болонезе"))
               .Sum(i => i.Quantity);

                var alfredoItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Алфредо"))
               .Sum(i => i.Quantity);

                var CarbonaraItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Карбонара"))
               .Sum(i => i.Quantity);

                var MarineraItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Маринара"))
               .Sum(i => i.Quantity);

                var PestoItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Песто"))
               .Sum(i => i.Quantity);


                //Изчисляване на процентното съотношение
                double total = bologneseItemsCount + alfredoItemsCount + CarbonaraItemsCount + MarineraItemsCount + PestoItemsCount;
                double bolonezePercentage = (bologneseItemsCount / total) * 100;
                double alfredoPercentage = (alfredoItemsCount / total) * 100;
                double carbonaraPercentage = (CarbonaraItemsCount / total) * 100;
                double marineraPercentage = (MarineraItemsCount / total) * 100;
                double pestoPercentage = (PestoItemsCount / total) * 100;


                // Създаване на кръговата диаграма
                SosPieChart.Series.Clear();
                SosPieChart.Series.Add("Артикули");
                SosPieChart.Series["Артикули"].Points.AddXY("Болонезе", bolonezePercentage);
                SosPieChart.Series["Артикули"].Points.AddXY("Алфредо", alfredoPercentage);
                SosPieChart.Series["Артикули"].Points.AddXY("Карбонара", carbonaraPercentage);
                SosPieChart.Series["Артикули"].Points.AddXY("Маринара", marineraPercentage);
                SosPieChart.Series["Артикули"].Points.AddXY("Песто", pestoPercentage);
                SosPieChart.Series["Артикули"].ChartType = SeriesChartType.Pie;


                SosPieChart.Legends.Clear();
                SosPieChart.Legends.Add(new Legend("АртикулиLegend"));
                SosPieChart.Series["Артикули"].Legend = "АртикулиLegend";
                SosPieChart.Series["Артикули"].IsVisibleInLegend = true;
                SosPieChart.Series["Артикули"].Label = "#PERCENT{P0}";
                List<string> sectorNames = new List<string>() { "болонезе", "алфредо", "карбонара", "маринара", "песто" };
                List<int> itemCounts = new List<int>() { bologneseItemsCount, alfredoItemsCount, CarbonaraItemsCount, MarineraItemsCount, PestoItemsCount }; // Използвайте стойностите, които имате за конкретната диаграма

                // Извикване на метода с подадените данни
                AddAnnotationToChart<Chart>(SosPieChart, sectorNames, itemCounts);
            }
        }
        public void InitializePiePastaChart()
        {
            // Извличане на броя на средните и големите елементи от базата данни
            using (var dbContext = new OrderDbContext())
            {
                var spagethiItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Спагети"))
               .Sum(i => i.Quantity);

                var taliateliItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Талиатели"))
               .Sum(i => i.Quantity);

                var fetuchiniItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Фетучини"))
               .Sum(i => i.Quantity);

                var parpadeliItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Парпадели"))
               .Sum(i => i.Quantity);

                var makaroniItemsCount = dbContext.Items
               .AsEnumerable()
               .Where(i => i.Name.Contains("Макарони"))
               .Sum(i => i.Quantity);


                //Изчисляване на процентното съотношение
                double total = spagethiItemsCount + taliateliItemsCount + fetuchiniItemsCount + parpadeliItemsCount + makaroniItemsCount;
                double spagetiPercentage = (spagethiItemsCount / total) * 100;
                double fetuchiniPercentage = (fetuchiniItemsCount / total) * 100;
                double parpadeliPercentage = (parpadeliItemsCount / total) * 100;
                double makaroniPercentage = (makaroniItemsCount / total) * 100;
                double taliatelePercentage = (taliateliItemsCount / total) * 100;


                // Създаване на кръговата диаграма
                PastaPieChart.Series.Clear();
                PastaPieChart.Series.Add("Артикули");
                PastaPieChart.Series["Артикули"].Points.AddXY("Спагети", spagetiPercentage);
                PastaPieChart.Series["Артикули"].Points.AddXY("Талиатели", taliatelePercentage);
                PastaPieChart.Series["Артикули"].Points.AddXY("Макарони", makaroniPercentage);
                PastaPieChart.Series["Артикули"].Points.AddXY("Фетучини", fetuchiniPercentage);
                PastaPieChart.Series["Артикули"].Points.AddXY("Парпаделе", parpadeliPercentage);
                PastaPieChart.Series["Артикули"].ChartType = SeriesChartType.Pie;


                PastaPieChart.Legends.Clear();
                PastaPieChart.Legends.Add(new Legend("АртикулиLegend"));
                PastaPieChart.Series["Артикули"].Legend = "АртикулиLegend";
                PastaPieChart.Series["Артикули"].IsVisibleInLegend = true;
                PastaPieChart.Series["Артикули"].Label = "#PERCENT{P0}";
                List<string> sectorNames = new List<string>() { "спагети", "талиатели", "макарони", "фетучини", "парпаделе" };
                List<int> itemCounts = new List<int>() { spagethiItemsCount, taliateliItemsCount, makaroniItemsCount, fetuchiniItemsCount, parpadeliItemsCount }; // Използвайте стойностите, които имате за конкретната диаграма

                // Извикване на метода с подадените данни
                AddAnnotationToChart<Chart>(PastaPieChart, sectorNames, itemCounts);
            }
        }
        public void AddAnnotationToChart<T>(Chart chart, List<string> sectorNames, List<int> itemCounts) where T : Control
        {
            var annotation = new TextAnnotation();
            annotation.AnchorAlignment = ContentAlignment.TopCenter; // Позициониране в горната част на диаграмата
            annotation.IsSizeAlwaysRelative = false;
            annotation.ForeColor = Color.Black;
            annotation.BackColor = Color.LightGray;
            annotation.Font = new Font("Arial", 10, FontStyle.Bold);
            annotation.Visible = false;

            chart.Annotations.Add(annotation);

            chart.MouseMove += (sender, e) =>
            {
                var pos = chart.PointToClient(Control.MousePosition);
                var results = chart.HitTest(pos.X, pos.Y);

                if (results != null && results.ChartElementType == ChartElementType.DataPoint)
                {
                    var dp = results.Object as DataPoint;
                    if (dp != null)
                    {
                        string labelText = dp.AxisLabel.ToLower();
                        int index = sectorNames.IndexOf(labelText);
                        if (index != -1 && index < itemCounts.Count)
                        {
                            int count = itemCounts[index];
                            annotation.Text = $"Сектор: {dp.AxisLabel} - Брой: {count}";
                            annotation.X = dp.XValue * 4;
                            annotation.Y = dp.YValues[0];
                            annotation.Visible = true;
                        }
                    }
                }
                else
                {
                    annotation.Visible = false;
                }
            };
        }
        private void NazadBtn2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
        /////////////////////////////////////////////////////////////////////////////////////////
        private void NewDostavchick_Click(object sender, EventArgs e)
        {
            DostavchiciForm form = new DostavchiciForm();
            form.ShowDialog();
            DostavchiciFLP.Controls.Clear();
            InitializeDostavchiciComboBox();
        }
        private void InitializeDostavchiciComboBox()
        {
            DostavchiciComboBox.Items.Clear();
            using (OrderDbContext db = new OrderDbContext())
            {
                foreach (var item in db.Dostavchici)
                {
                    DostavchiciComboBox.Items.Add(item);
                }
            }
            DostavchiciComboBox.DisplayMember = "Name";
            DostavchiciComboBox.SelectedIndexChanged += DostavchiciComboBox_SelectedIndexChanged;
        }

        private void DostavchiciComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                DostavchikEntity choosenDostavhcik = new DostavchikEntity();
                if (sender is ComboBox comboBox)
                {
                    choosenDostavhcik = comboBox.SelectedItem as DostavchikEntity;
                    if (choosenDostavhcik != null)
                    {

                       choosenDostavhcik = db.Dostavchici.FirstOrDefault(x => x.Id == choosenDostavhcik.Id);
                    }
                }
               
                DostavchiciFLP.FlowDirection = FlowDirection.TopDown;
                DostavchiciFLP.Controls.Clear();

                // Now iterate over the loaded elements and add them to DostavchiciFLP
                foreach (var item in choosenDostavhcik.Elements)
                {
                    // Създаване на текстово поле за текущия елемент
                    TextBox textBox = new TextBox(); textBox.Name = item.Name;


                    // Създаване на контейнер, който съдържа името на елемента и текстовото поле
                    FlowLayoutPanel panel = new FlowLayoutPanel();
                    panel.FlowDirection = FlowDirection.LeftToRight;
                    panel.AutoSize = true;
                    panel.Controls.Add(new Label() { Text = item.Name, AutoSize = true }); // Добавяне на името на елемента
                    panel.Controls.Add(textBox); // Добавяне на текстовото поле
                    panel.Controls.Add(new Label() { Text = item.Type, AutoSize = true });
                    // Добавяне на контейнера като елемент на FLP
                    DostavchiciFLP.Controls.Add(panel);

                }
                Button saveButton = new Button() { AutoSize = true };
                saveButton.Text = "Запази";
                saveButton.Click += SaveButton_Click;

                // Задаване на Dock свойството на бутона "Запази" на Bottom, за да седи в долната част на FLP
                saveButton.Dock = DockStyle.Bottom;

                // Добавяне на бутона "Запази" към FLP
                DostavchiciFLP.Controls.Add(saveButton);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            foreach (var item in DostavchiciFLP.Controls)
            {
                if (item.GetType() == typeof(FlowLayoutPanel))
                {
                    FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)item;
                    for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
                    {
                        if (flowLayoutPanel.Controls[i].GetType() == typeof(TextBox))
                            panel.Controls.Add((Control)flowLayoutPanel.Controls[i]);
                    }
                }

            }

            using (OrderDbContext db = new OrderDbContext())
            {
                DostavkaEntity dostavka = new DostavkaEntity();
                dostavka.Stuff = new List<DostavkaElementiEntity>();
                bool succsess = false;
                foreach (var item in panel.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {

                        TextBox textBox = (TextBox)item;

                        ElementEntity element = db.Elements.Where(x => x.Name == textBox.Name).FirstOrDefault();
                        if (element.Type == "Бр")
                        {
                            if (textBox.Text != "")
                            {
                                try
                                {
                                    element.Quantity += int.Parse(textBox.Text);
                                    succsess = true;
                                    dostavka.Stuff.Add(new DostavkaElementiEntity(element.Name, element.Type, int.Parse(textBox.Text), 0));
                                }
                                catch
                                {
                                    MessageBox.Show("Невалиден формат");
                                    succsess = false;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (textBox.Text != "")
                            {
                                try
                                {
                                    element.Kg += double.Parse(textBox.Text);
                                    succsess = true;
                                    dostavka.Stuff.Add(new DostavkaElementiEntity(element.Name, element.Type, 0, int.Parse(textBox.Text)));
                                }
                                catch
                                {

                                    MessageBox.Show("Невалиден формат");
                                    succsess = false;
                                    break;
                                }
                            }

                        }
                    }
                }

                DostavchiciFLP.Controls.Clear();
                if (succsess)
                {
                    DostavchikEntity choosenDostavhcik = (DostavchikEntity)DostavchiciComboBox.SelectedItem;
                    dostavka.DostavkaDate = dateTimePicker1.Value;
                    dostavka.Name = choosenDostavhcik.Name;

                    db.Dostavki.Add(dostavka);
                    db.SaveChanges();
                    DostavchiciFLP.Controls.Add(new Label() { Text = "Доставката добавена успешно!", AutoSize = true });
                }

                else
                {
                    DostavchiciFLP.Controls.Add(new Label() { Text = "Няма добавен елемент!", AutoSize = true });
                }
                succsess = false;
            }

        }
    
        private void Istoria_Click(object sender, EventArgs e)
        {
            IstoriaNaPoruchkiForm istoriaNaPoruchkiForm = new IstoriaNaPoruchkiForm();
            istoriaNaPoruchkiForm.ShowDialog();
        }

        private void NazadBtn3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void Skrap_Click(object sender, EventArgs e)
        {
            SkrapForm skrap = new SkrapForm();
            skrap.ShowDialog();
        }
        //--------------------------------------------------------------------------------------------------

        private void ViewReviziqElements()
        {
            using(OrderDbContext db= new OrderDbContext())
            {
                foreach (var item in db.Elements)
                {
                    FlowLayoutPanel flp = new FlowLayoutPanel();

                    flp.Controls.Add(new Label() { Text = item.Name, AutoSize = true });
                    flp.Controls.Add(new Label() { Text = item.Type, AutoSize = true });
                    ElemenetFlp.Controls.Add(flp);
                }
            }
        }
        private void IstoriqReviziiBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
