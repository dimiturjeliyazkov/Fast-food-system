using FastFoodSystem.ManagmentSystem.Entities;
using FastFoodSystem.OrderSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FastFoodSystem.ManagmentSystem.Forms
{
    public partial class NovDostavchik : Form
    {
        public static ICollection<ElementEntity> Elements;
        public NovDostavchik(ICollection<ElementEntity> Elementss)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            Elements = Elementss;
            viewElements();
        }

        private void ZapaziBtn_Click(object sender, EventArgs e)
        {
            using(OrderDbContext db = new OrderDbContext())
            {
                db.Dostavchici.Add(new DostavchikEntity(DostavchikImeTxt.Text, DostavchikOpisanieTxt.Text, Elements));
                db.SaveChanges();
            }
            Hide();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void DobaviElementBtn_Click(object sender, EventArgs e)
        {
            Element element = new Element(Elements);
            element.ShowDialog();
            viewElements();
        }
        public void viewElements()
        {
            ElementiListBox.Items.Clear();
            foreach (var item in Elements)
            {
                string Element = $"{ item.Name} - {item.Type}";
                ElementiListBox.Items.Add(Element);
                ElementiListBox.MouseDoubleClick += ElementiListBox_MouseDoubleClick;
            }
        }
        private void ElementiListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedElement = ElementiListBox.SelectedItem.ToString();
            DialogResult result = MessageBox.Show($"Сигурни ли сте, че искате да изтриете елемента '{selectedElement}'?", "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ElementiListBox.Items.Remove(selectedElement);
            }
        }
    }
}
