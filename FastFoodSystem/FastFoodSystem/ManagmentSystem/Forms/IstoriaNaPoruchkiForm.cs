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
    public partial class IstoriaNaPoruchkiForm : Form
    {
        public IstoriaNaPoruchkiForm()
        {
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            ViewDostavkiHistory();
        }
        
        private void ViewDostavkiHistory()
        {
            DostavchiTLP.Controls.Clear();
            using(OrderDbContext dbContext = new OrderDbContext())
            {
                foreach (var item in dbContext.Dostavki)
                {
                    Button button = new Button() { AutoSize = true };
                    button.Text = $"{item.Id} - {item.Name} - {item.DostavkaDate}";
                    button.TabIndex = item.Id;
                    button.Click += ShowElements;
                    DostavchiTLP.Controls.Add(button);
                }
            }
        }

        private void ShowElements(object sender, EventArgs e)
        {
            ElementsTLP.Controls.Clear();
            Button btn = sender as Button;
            using(OrderDbContext dbContext = new OrderDbContext())
            {
                DostavkaEntity dostavkaEntity = dbContext.Dostavki.Where(x => x.Id == btn.TabIndex).FirstOrDefault();
                foreach (var item in dostavkaEntity.Stuff)
                {
                    ElementsTLP.Controls.Add(new Label()
                    {
                        Text = $"{item.Name} - {(item.Type == "Бр" ? item.Quantity.ToString() : item.Kg.ToString())}{item.Type}",
                        AutoSize = true
                    });
                }
            }
            
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DostavchiTLP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ElementsTLP_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
