using FastFoodSystem.ManagmentSystem.Entities;
using FastFoodSystem.OrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FastFoodSystem.ManagmentSystem.Forms
{
    public partial class SkrapForm : Form
    {
        public SkrapForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            InitaliazeElements();
        }

        public void InitaliazeElements()
        {
            DostavchiciFLP.FlowDirection = FlowDirection.TopDown;
            DostavchiciFLP.Controls.Clear();
            DostavchiciFLP.AutoScroll = true;

            using (OrderDbContext db = new OrderDbContext())
            {
                var groupedElements = db.Elements.GroupBy(x => x.DostavchikEntityId).ToList();

                DostavchiciFLP.SuspendLayout();

                foreach (var group in groupedElements)
                {
                    // Извличане на информация за групата от базата данни
                    var groupInfo = db.Dostavchici.FirstOrDefault(x => x.Id == group.Key);

                    // Създаване на FlowLayoutPanel за всяка група
                    FlowLayoutPanel groupPanel = new FlowLayoutPanel();
                    groupPanel.FlowDirection = FlowDirection.TopDown;
                    groupPanel.AutoSize = true;
                    groupPanel.Padding = new Padding(0, 0, 0, 10); // Добавяне на разстояние отдолу (10 пиксела)

                    // Добавяне на име на групата, ако има информация за нея
                    if (groupInfo != null)
                    {
                        groupPanel.Controls.Add(new Label() { Text = groupInfo.Name, AutoSize = true, Font = new Font("Arial", 12, FontStyle.Bold) });
                    }
                    else
                    {
                        groupPanel.Controls.Add(new Label() { Text = "Група " + group.Key, AutoSize = true, Font = new Font("Arial", 12, FontStyle.Bold) });
                    }

                    foreach (var item in group)
                    {
                        // Създаване на текстово поле за текущия елемент
                       

                        // Добавяне на контейнер към FlowLayoutPanel на групата
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel.FlowDirection = FlowDirection.LeftToRight;
                        panel.AutoSize = true;
                        panel.Controls.Add(new Label() { Text = item.Name, AutoSize = true }); // Добавяне на името на елемента
                        panel.Controls.Add(new TextBox()); // Добавяне на текстовото поле
                        panel.Controls.Add(new Label() { Text = item.Type, AutoSize = true });

                        groupPanel.Controls.Add(panel); // Добавяне на контейнера към групата
                    }

                    // Добавяне на FlowLayoutPanel за групата към основния FlowLayoutPanel
                    DostavchiciFLP.Controls.Add(groupPanel);
                }

                DostavchiciFLP.AutoScroll = true; // Активиране на автоматичния скрол

                // Плъзгане нагоре
                DostavchiciFLP.VerticalScroll.Value = 0;

                DostavchiciFLP.ResumeLayout();
            }

            // Now iterate over the loaded elements and add them to DostavchiciFLP
            Button saveButton = new Button() { AutoSize = true };
            saveButton.Text = "Запази";
            saveButton.Click += SaveButton_Click;

            // Задаване на Dock свойството на бутона "Запази" на Bottom, за да седи в долната част на FLP
            saveButton.Dock = DockStyle.Bottom;

            // Добавяне на бутона "Запази" към FLP
            DostavchiciFLP.Controls.Add(saveButton);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            using(OrderDbContext db = new OrderDbContext())
            {
                SkrapEntity skrapEntity = new SkrapEntity();
                skrapEntity.SkrapDate = DateTime.Now;
                skrapEntity.Name = $"{skrapEntity.Id}: {skrapEntity.SkrapDate}";
                skrapEntity.Stuff = new List<SkrapElementiEntity>();
                foreach ( var Flow in DostavchiciFLP.Controls)
                {
                    if(Flow is FlowLayoutPanel)
                    {
                        FlowLayoutPanel fl = (FlowLayoutPanel)Flow;
                        foreach (var item in fl.Controls)
                        {
                            if (item is FlowLayoutPanel)
                            {
                                FlowLayoutPanel flow = (FlowLayoutPanel)item;
                                Label name = flow.Controls[0] as Label;
                                TextBox value = flow.Controls[1] as TextBox;
                                Label type = flow.Controls[2] as Label;
                               
                                if (value.Text != "")
                                {
                                    if (type.Text == "Бр")
                                    {
                                        db.Elements.Where(x => x.Name == name.Text).FirstOrDefault().Quantity -= int.Parse(value.Text);
                                        skrapEntity.Stuff.Add(new SkrapElementiEntity(name.Text,type.Text,int.Parse(value.Text),0));
                                    }
                                    else
                                    {
                                        db.Elements.Where(x => x.Name == name.Text).FirstOrDefault().Kg -= double.Parse(value.Text);
                                        skrapEntity.Stuff.Add(new SkrapElementiEntity(name.Text, type.Text, 0,double.Parse(value.Text)));
                                    }

                                }

                            }
                        }
                    }
                }
                db.Skrapki.Add(skrapEntity);
                db.SaveChanges();
                MessageBox.Show("Успешно скрапнахте дадените елементи!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void IstoriaSkrap_Click(object sender, EventArgs e)
        {
            IstoriaSkrap istoriaSkrap = new IstoriaSkrap(); 
            istoriaSkrap.ShowDialog();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
