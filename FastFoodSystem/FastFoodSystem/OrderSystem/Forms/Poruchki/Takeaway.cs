using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompleteSystem.OrdersSystem;
using CompleteSystem.OrdersSystem.Models;

namespace PastaMadnessSystem
{
    public partial class Takeaway : Form
    {
        
        // private ItemHolder dataHolder = new ItemHolder();
        Poruchka thisOrder = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka;
        public Takeaway()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            thisOrder.type = "Takeaway";
            CenaNaPoruchkaLBL.Text = $"Takeaway поръчка номер: {this.thisOrder.PoruckaNomer}\nОбща цена на сметката: {thisOrder.Price}лв.";
        }

        private void showAllItems()
        {
            ListItemsTLP.RowStyles.Clear();
            ListItemsTLP.Controls.Clear();

            ListItemsTLP.RowCount = thisOrder.Items.Count;
            ListItemsTLP.ColumnCount = 4;

            int index = 0;

            foreach (var item in thisOrder.Items)
            {

                Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka.UpdateTotalPrice();

                // Create a button for each Poruchka item and set its font size
                Label napitka = new Label();
                napitka.Text = $"{item.Name} {item.Quantity}бр. - {item.totalSum:F2}лв.";
                napitka.AutoSize = true;
                napitka.Font = new Font("Arial", 20);

                FlowLayoutPanel row = new FlowLayoutPanel();
                row.AutoSize = true;
                row.FlowDirection = FlowDirection.LeftToRight; // Change here

                // Add controls to the same row but different columns
                row.Controls.Add(napitka);

                // Unsubscribe previous event handlers
                item.plus.Click -= PlusButtonClickHandler;
                item.minus.Click -= MinusButtonClickHandler;
                item.Remove.Click -= RemoveButtonClickHandler;
                if (item.Name.Split(' ' ).ToList()[0] == "Средни" || item.Name.Split(' ' ).ToList()[0] == "Големи")
                {
                    item.Edit.Click -= EditButtonClickHandler;
                }

                // Set the Tag property to the corresponding Item
                item.plus.Tag = item;
                item.minus.Tag = item;
                item.Remove.Tag = item;
                if (item.Name.Split(' ' ).ToList()[0] == "Средни" || item.Name.Split(' ' ).ToList()[0] == "Големи")
                {
                    item.Edit.Tag = item;
                    item.Edit.TabIndex = thisOrder.Items.IndexOf(item);
                }

                // Subscribe new event handlers
                item.plus.Click += PlusButtonClickHandler;
                item.minus.Click += MinusButtonClickHandler;
                item.Remove.Click += RemoveButtonClickHandler;
                if (item.Name.Split(' ' ).ToList()[0] == "Средни" || item.Name.Split(' ' ).ToList()[0] == "Големи")
                {
                    item.Edit.Click += EditButtonClickHandler;
                }

                row.Controls.Add(item.plus);
                row.Controls.Add(item.minus);
                row.Controls.Add(item.Remove);
                if (item.Name.Split(' ' ).ToList()[0] == "Средни" || item.Name.Split(' ' ).ToList()[0] == "Големи")
                {
                    row.Controls.Add(item.Edit);
                }

                // Add the row to the TableLayoutPanel
                ListItemsTLP.Controls.Add(row, 0, index);
                index++;
            }
            thisOrder.UpdateTotalPrice();
            CenaNaPoruchkaLBL.Text = $"Обща цена на сметката: {thisOrder.Price:F2}лв.";
        }
        private void EditButtonClickHandler(object sender, EventArgs e)
        {
            Pasta.isNewPasta = false;

            Button editButton = (Button)sender;
            Pasta.nomerNapasta = editButton.TabIndex;
            Item item = (Item)editButton.Tag;

            item.PastaForm.ShowDialog();
            item.UpdateTotalSum();

            // Refresh the displayed items
            showAllItems();
        }


        private void PlusButtonClickHandler(object sender, EventArgs e)
        {
            // Extract the Item associated with the clicked button
            Button plusButton = (Button)sender;
            Item item = (Item)plusButton.Tag;

            item.Quantity++;
            item.UpdateTotalSum();

            // Refresh the displayed items
            showAllItems();
        }
        private void MinusButtonClickHandler(object sender, EventArgs e)
        {
            // Extract the Item associated with the clicked button
            Button minusButton = (Button)sender;
            Item item = (Item)minusButton.Tag;

            if (item.Quantity > 1)
            {
                item.Quantity--;
                item.UpdateTotalSum();
            }

            // Refresh the displayed items
            showAllItems();
        }

        private void RemoveButtonClickHandler(object sender, EventArgs e)
        {
            // Extract the Item associated with the clicked button
            Button removeButton = (Button)sender;
            Item item = (Item)removeButton.Tag;

            // Remove the item from the list
            thisOrder.Items.Remove(item);

            // Refresh the displayed items
            showAllItems();
        }

        private void PastaBtn_Click(object sender, EventArgs e)
        {
            Pasta.isNewPasta = true;
            Pasta pasta = new Pasta();
            pasta.ShowDialog();
            showAllItems();
        }

        private void NapitkaBtn_Click(object sender, EventArgs e)
        {
            Napitki napitki = new Napitki();
            napitki.ShowDialog();

            showAllItems();
        }

        private void DesertiBtn_Click(object sender, EventArgs e)
        {
            Deserti deserti = new Deserti();
            deserti.ShowDialog();

            showAllItems();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RazplashtaneBtn_Click(object sender, EventArgs e)
        {
            Razplashtane razplashtane = new Razplashtane();
            razplashtane.ShowDialog();
            if (FullOrder.isRazplatena)
                Hide();
        }

        private void IztrivaneBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
               ("Сигурни ли сте, че искате да изтриете поръчката?", "Потвърждение на изтриване", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Poruchki.Celiporuchki.RemoveAt(Poruchki.poziciqNaPoruchka);
                this.Hide();
            }
        }
    }
}
