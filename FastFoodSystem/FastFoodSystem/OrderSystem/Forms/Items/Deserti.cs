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
    public partial class Deserti : Form
    {
        public Deserti()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ShokoPastaBtn_Click(object sender, EventArgs e)
        {
            Poruchka poruchka = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka;
            if (poruchka.Items.Any(item => item.Name == "Шоко паста"))
            {
                poruchka.Items.FirstOrDefault(item => item.Name == "Шоко паста").Quantity++;
                poruchka.Items.FirstOrDefault(item => item.Name == "Шоко паста").UpdateTotalSum();
                poruchka.UpdateTotalPrice();
                Hide();
            }
            else
            {
                poruchka.Items.Add(new Item("Шоко паста", 5.20, "dessert"));
                poruchka.UpdateTotalPrice();
                Hide();
            }
        }

        private void MakNaFurnBtn_Click(object sender, EventArgs e)
        {
            Poruchka poruchka = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka;
            if (poruchka.Items.Any(item => item.Name == "Макарони на фурна"))
            {
                poruchka.Items.FirstOrDefault(item => item.Name == "Макарони на фурна").Quantity++;
                poruchka.Items.FirstOrDefault(item => item.Name == "Макарони на фурна").UpdateTotalSum();
                poruchka.UpdateTotalPrice();
                Hide();
            }
            else
            {
                poruchka.Items.Add(new Item("Макарони на фурна", 5.20, "dessert"));
                poruchka.UpdateTotalPrice();
                Hide();
            }
        }

        private void ShokoRaviBtn_Click(object sender, EventArgs e)
        {
            Poruchka poruchka = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka;
            if (poruchka.Items.Any(item => item.Name == "Шоко Равиоли"))
            {
                poruchka.Items.FirstOrDefault(item => item.Name == "Шоко Равиоли").Quantity++;
                poruchka.Items.FirstOrDefault(item => item.Name == "Шоко Равиоли").UpdateTotalSum();
                poruchka.UpdateTotalPrice();
                Hide();
            }
            else
            {
                poruchka.Items.Add(new Item("Шоко Равиоли", 5.20,"dessert"));
                poruchka.UpdateTotalPrice();
                Hide();
            }
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void NazadBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
