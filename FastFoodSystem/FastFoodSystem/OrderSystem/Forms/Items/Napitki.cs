using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompleteSystem.OrdersSystem.Models;


namespace PastaMadnessSystem
{
    public partial class Napitki : Form
    {
        // private ItemHolder itemHolder;
        public Napitki()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            /// this.itemHolder = itemHolder;
        }

        private void KolaBtn_Click(object sender, EventArgs e)
        {
            Poruchka poruchka = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka;
            if (poruchka.Items.Any(item => item.Name == "Кола"))
            {
                poruchka.Items.FirstOrDefault(item => item.Name == "Кола").Quantity++;
                poruchka.Items.FirstOrDefault(item => item.Name == "Кола").UpdateTotalSum();
                poruchka.UpdateTotalPrice();
                Hide();
            }
            else
            {
                poruchka.Items.Add(new Item("Кола", 1.20, "drink"));
                
                poruchka.UpdateTotalPrice();
                Hide();
            }
        }

        private void FantaBtn_Click(object sender, EventArgs e)
        {
            Poruchka poruchka = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka; ;
            if (poruchka.Items.Any(item => item.Name == "Fanta"))
            {
                poruchka.Items.FirstOrDefault(item => item.Name == "Fanta").Quantity++;
                poruchka.Items.FirstOrDefault(item => item.Name == "Fanta").UpdateTotalSum();
                poruchka.UpdateTotalPrice();
                Hide();
            }
            else
            {
                poruchka.Items.Add(new Item("Fanta", 1.20,"drink"));
                poruchka.UpdateTotalPrice();
                Hide();
            }
        }

        private void VodaBtn_Click(object sender, EventArgs e)
        {
            Poruchka poruchka = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka; 
            if (poruchka.Items.Any(item => item.Name == "Вода"))
            {
                poruchka.Items.FirstOrDefault(item => item.Name == "Вода").Quantity++;
                poruchka.Items.FirstOrDefault(item => item.Name == "Вода").UpdateTotalSum();
                poruchka.UpdateTotalPrice();
                Hide();
            }
            else
            {
                poruchka.Items.Add(new Item("Вода", 1.20,"drink"));
                poruchka.UpdateTotalPrice();
                Hide();
            }
        }

        private void StudenChaiBtn_Click(object sender, EventArgs e)
        {
            Poruchka poruchka = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka; ;
            if (poruchka.Items.Any(item => item.Name == "Студен чай"))
            {
                poruchka.Items.FirstOrDefault(item => item.Name == "Студен чай").Quantity++;
                poruchka.Items.FirstOrDefault(item => item.Name == "Студен чай").UpdateTotalSum();
                poruchka.UpdateTotalPrice();
                Hide();
            }
            else
            {
                poruchka.Items.Add(new Item("Студен чай", 1.20, "drink"));
                poruchka.UpdateTotalPrice();
                Hide();
            }
        }

        private void VinoBtn_Click(object sender, EventArgs e)
        {
            Poruchka poruchka = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka; ;
            if (poruchka.Items.Any(item => item.Name == "Вино"))
            {
                poruchka.Items.FirstOrDefault(item => item.Name == "Вино").Quantity++;
                poruchka.Items.FirstOrDefault(item => item.Name == "Вино").UpdateTotalSum();
                poruchka.UpdateTotalPrice();
                Hide();
            }
            else
            {
                poruchka.Items.Add(new Item("Вино", 1.20, "drink"));
                poruchka.UpdateTotalPrice();
                Hide();
            }
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
