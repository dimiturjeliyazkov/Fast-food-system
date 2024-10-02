using FastFoodSystem.ManagmentSystem.Entities;
using FastFoodSystem.ManagmentSystem.Models;
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
using System.Xml.Linq;

namespace FastFoodSystem.ManagmentSystem.Forms
{
    public partial class EditDostavchik : Form
    {
        DostavchikEntity Dostavchik;
        
        public EditDostavchik(DostavchikEntity dostavchik)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            Dostavchik = dostavchik;
            viewElements();
        }

        private void ZapaziBtn_Click(object sender, EventArgs e)
        {
            Dostavchik.Name = DostavchikImeTxt.Text;
            Dostavchik.Description = DostavchikOpisanieTxt.Text;

            Hide();
        }
        public void viewElements()
        {
            ElementiListBox.Items.Clear();
            foreach (var item in Dostavchik.Elements)
            {
                string Element = $"{item.Name} - {item.Type}";
                ElementiListBox.Items.Add(Element);
                
            }
            ElementiListBox.MouseDoubleClick += ElementiListBox_MouseDoubleClick;
        }
        private void ElementiListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ElementiListBox.SelectedItem != null)
            {
                string selectedElement = ElementiListBox.SelectedItem.ToString();
                DialogResult result = MessageBox.Show($"Сигурни ли сте, че искате да изтриете елемента '{selectedElement}'?", "Потвърждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedIndex = ElementiListBox.SelectedIndex;
                    ElementiListBox.Items.RemoveAt(selectedIndex);

                    string elementNameToRemove = selectedElement.Split(new string[] { " - " }, StringSplitOptions.None).FirstOrDefault();

                    // Изтриваме елемента от колекцията на Dostavchik.Elements
                    var elementToRemove = Dostavchik.Elements.FirstOrDefault(x => x.Name == elementNameToRemove);
                    if (elementToRemove != null)
                    {
                        using (OrderDbContext db = new OrderDbContext())
                        {
                            db.Elements.RemoveRange(db.Elements.Where(x=>x.Name == elementNameToRemove));   
                            db.SaveChanges();
                        }
                           
                    }
                }
            }
        }

        private void DobaviElementBtn_Click(object sender, EventArgs e)
        {
            Element element = new Element(Dostavchik.Elements);
            element.ShowDialog();
            viewElements();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void IztriBtn_Click(object sender, EventArgs e)
        {
            using (OrderDbContext db = new OrderDbContext())
            {
                var entity = db.Dostavchici.Find(Dostavchik.Id);
                db.Dostavchici.Remove(entity);
                db.SaveChanges();
            }
            Hide();
        }
    }
}
