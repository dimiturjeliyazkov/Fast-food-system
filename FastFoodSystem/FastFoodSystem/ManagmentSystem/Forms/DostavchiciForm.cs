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
    public partial class DostavchiciForm : Form
    {
        public DostavchiciForm()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            showAllDostavchiks();
        }

        private void NewDostavchick_Click(object sender, EventArgs e)
        {
            NovDostavchik novDostavchik = new NovDostavchik(new List<ElementEntity>());
            novDostavchik.ShowDialog();
            showAllDostavchiks();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public void showAllDostavchiks()
        {
            DostavchiciListBox.Items.Clear();
            using (OrderDbContext db = new OrderDbContext())
            {
                //if(db.Dostavchici != null)
                foreach (var item in db.Dostavchici)
                {
                    DostavchiciListBox.Items.Add($"{item.Id} {item.Name}-{item.Description}");
                    
                }
            }
            DostavchiciListBox.Click += DostavchiciListBox_Click;
        }

        private void DostavchiciListBox_Click(object sender, EventArgs e)
        {
            if (DostavchiciListBox.SelectedIndex != -1)
            {
                // Retrieve the selected item
                string selectedItem = DostavchiciListBox.SelectedItem.ToString();

                // Call your method with the selected item
                ViewDostavchik(selectedItem);
            }
        }
        private void ViewDostavchik(string selectedItem)
        {
            //DostavchikEntity dostavchik = new DostavchikEntity();
            int id = int.Parse(selectedItem.Split(' ').FirstOrDefault());
           
            using (OrderDbContext db = new OrderDbContext())
            {
                DostavchikEntity dostavchik = db.Dostavchici.Where(x => x.Id == id).FirstOrDefault();
                EditDostavchik editDostavchik = new EditDostavchik(dostavchik);
                editDostavchik.DostavchikImeTxt.Text = dostavchik.Name;
                editDostavchik.DostavchikOpisanieTxt.Text = dostavchik.Description;
                
                editDostavchik.ShowDialog();
                db.SaveChanges();
            }
            showAllDostavchiks();
        }
    }
}
