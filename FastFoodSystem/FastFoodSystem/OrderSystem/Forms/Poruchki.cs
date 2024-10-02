using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompleteSystem.OrdersSystem;
using FastFoodSystem;

namespace PastaMadnessSystem
{
    public partial class Poruchki : Form
    {
        public static List<FullOrder> Celiporuchki = new List<FullOrder>();
        public static int poziciqNaPoruchka;
        public Poruchki()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            showAllPoruchki();


        }
        public void showAllPoruchki()
        {
            ListSPoruchkiTLP.RowStyles.Clear();
            ListSPoruchkiTLP.Controls.Clear();

            foreach (var poruchka in Celiporuchki)
            {
                // Create a button for each Poruchka item and set its font size

                Button button = poruchka.button;
                button.AutoSize = true;

                if (poruchka.form != null)
                {
                    button.Text = $"(Нормална) Поръчка номер: {poruchka.poruchka.PoruckaNomer} - {poruchka.poruchka.Price:F2}лв.";
                }
                else if (poruchka.glovo != null)
                {
                    button.Text = $"(Glovo) Поръчка номер: {poruchka.poruchka.PoruckaNomer} - {poruchka.poruchka.Price:F2}лв.";
                    button.BackColor = Color.Yellow;
                    button.ForeColor = Color.DarkGreen;
                }
                else if(poruchka.takeaway != null)
                {
                    button.Text = $"(Takeaway) Поръчка номер: {poruchka.poruchka.PoruckaNomer} - {poruchka.poruchka.Price:F2}лв.";
                    button.BackColor = Color.Orange;
                    button.ForeColor = Color.White;
                }


                button.Font = new Font("Arial", 20); // Set the font and size as needed
                button.TabIndex = Celiporuchki.IndexOf(poruchka);
                button.Click -= OpenIndividualnaPoruchaForm;
                button.Click += OpenIndividualnaPoruchaForm;



                // Add the button to the TableLayoutPanel at the specified row
                ListSPoruchkiTLP.Controls.Add(button, 0, poruchka.poruchka.PoruckaNomer);

            }
        }

        private void NovaPoruchkaBtn_Click(object sender, EventArgs e)
        {
            Celiporuchki.Add(new FullOrder());
            poziciqNaPoruchka = Celiporuchki.IndexOf(Celiporuchki.Last());
            Celiporuchki.Last().form = new IndividualnaPorucha();
            Celiporuchki.Last().form.ShowDialog();
            showAllPoruchki();

            // Refresh the form to update the displayed list
        }
        private void OpenIndividualnaPoruchaForm(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            poziciqNaPoruchka = clickedButton.TabIndex;
            if (clickedButton.Text[1] == 'Н')
            {
                Celiporuchki[poziciqNaPoruchka].form.ShowDialog();
            }
            else if (clickedButton.Text[1] == 'G')
            {
                Celiporuchki[poziciqNaPoruchka].glovo.ShowDialog();
            }
            else if (clickedButton.Text[1] == 'T')
            {
                Celiporuchki[poziciqNaPoruchka].takeaway.ShowDialog();
            }

            showAllPoruchki();
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void GlovoBtn_Click(object sender, EventArgs e)
        {
            Celiporuchki.Add(new FullOrder());
            poziciqNaPoruchka = Celiporuchki.IndexOf(Celiporuchki.Last());
            Celiporuchki.Last().glovo = new Glovo();
            Celiporuchki.Last().glovo.ShowDialog();
            showAllPoruchki();

        }

        private void TakeawayBtn_Click(object sender, EventArgs e)
        {
            Celiporuchki.Add(new FullOrder());
            poziciqNaPoruchka = Celiporuchki.IndexOf(Celiporuchki.Last());
            Celiporuchki.Last().takeaway = new Takeaway();
            Celiporuchki.Last().takeaway.ShowDialog();
            showAllPoruchki();
        }
    }
}

