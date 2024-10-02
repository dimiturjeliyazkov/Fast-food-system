using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using CompleteSystem.OrdersSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PastaMadnessSystem
{
    public partial class Pasta : Form
    {
        public static bool isNewPasta = true;
        public static int nomerNapasta;
        int counter = 0;
        public static string recepta;
        double cenaNaRazmer = 0;
        double cenaNaDobavki = 0;
        static string originalString = "first second third";
        string[] pastaOpisanie = originalString.Split(' ');
        public Pasta()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            BolonezeRADBTN.Checked = true;
            SpagetiRADBTN.Checked = true;
           
        }

        private void GolqmaRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            cenaNaRazmer = 8.9;
            updateCena();
            pastaOpisanie[0] = GolqmaRADBTN.Text;
            if(counter==2)
            checkSize();
        }

        private void srednoRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            counter++;
            cenaNaRazmer = 6.9;
            updateCena();
            pastaOpisanie[0] = srednoRADBTN.Text;
            if(counter==2) 
            checkSize();
        }

        private void checkSize()
        {
            foreach (CheckBox box in MesaGB.Controls)
            {
                if (box.Checked == true)
                {
                    if (GolqmaRADBTN.Checked == true)
                        cenaNaDobavki += 0.50;
                    else if (srednoRADBTN.Checked == true)
                        cenaNaDobavki -= 0.50;
                }
            }
            foreach (CheckBox box in ZelenchuciGB.Controls)
            {
                if (box.Checked == true)
                {
                    if (GolqmaRADBTN.Checked == true)
                        cenaNaDobavki += 0.50;
                    else if (srednoRADBTN.Checked == true)
                        cenaNaDobavki -= 0.50;
                }
            }
            foreach (CheckBox box in SirenaGB.Controls)
            {
                if (box.Checked == true)
                {
                    if (GolqmaRADBTN.Checked == true)
                        cenaNaDobavki += 0.50;
                    else if (srednoRADBTN.Checked == true)
                        cenaNaDobavki -= 0.50;
                }
            }
            foreach (CheckBox box in MorskiDaroveGB.Controls)
            {
                if (box.Checked == true)
                {
                    if (GolqmaRADBTN.Checked == true)
                        cenaNaDobavki += 0.50;
                    else if(srednoRADBTN.Checked == true)
                        cenaNaDobavki -= 0.50;
                }
            }
            counter = 0;    
        }

        private void gotovoBtn_Click(object sender, EventArgs e)
        {
            Poruchka poruchka = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka;
            if (isNewPasta == true)
            {
                
                string modifiedString = string.Join(" ", pastaOpisanie);

                poruchka.Items.Add(new Item(modifiedString, cenaNaRazmer + cenaNaDobavki,"Pasta"));
                poruchka.Items.Last().PastaForm = this;
                poruchka.Items.Last().Ingridients.Clear();

                poruchka.UpdateTotalPrice();
                Hide();
            }
            else
            {
               
                string modifiedString = string.Join(" ", pastaOpisanie);
                poruchka.Items[nomerNapasta] = new Item(modifiedString, cenaNaRazmer + cenaNaDobavki, "Pasta");
                poruchka.Items[nomerNapasta].Ingridients.Clear();
                poruchka.Items[nomerNapasta].PastaForm = this;
                poruchka.UpdateTotalPrice();
                Hide();
            }

            foreach (RadioButton ingredient in PastaGB.Controls)
            {
                if (srednoRADBTN.Checked == true)
                {
                    if (ingredient.Checked == true)
                    {
                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.15,"Pasta"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.15, "Pasta"));
                        }

                    }
                }
                else
                {
                    if (ingredient.Checked == true)
                    {
                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.2, "Pasta"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.2, "Pasta"));
                        }

                    }
                }

            }

            foreach (RadioButton ingredient in SosGB.Controls)
            {
                if (srednoRADBTN.Checked == true)
                {
                    if (ingredient.Checked == true)
                    {
                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.15,"Sos"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.15, "Sos"));
                        }

                    }
                }
                else
                {
                    if (ingredient.Checked == true)
                    {
                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.2,"Sos"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.2,"Sos"));
                        }

                    }
                }

            }

            foreach (CheckBox ingredient in MesaGB.Controls)
            {
                if (srednoRADBTN.Checked == true)
                {
                    if (ingredient.Checked == true)
                    {
                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text,0.05, "ingridient"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text,0.5, "ingridient"));
                        }

                    }
                   
                }
                else
                {

                    if (ingredient.Checked == true)
                    {

                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.1, "ingridient"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.1,"ingridient"));
                        }
                    }
                }

            }

            foreach (CheckBox ingredient in ZelenchuciGB.Controls)
            {
                if (srednoRADBTN.Checked == true)
                {
                    if (ingredient.Checked == true)
                    {
                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.05, "ingridient"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.1, "ingridient"));
                        }
                         
                    }
                    
                }
                else
                {

                    if (ingredient.Checked == true)
                    {

                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.1, "ingridient"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.1, "ingridient"));
                        }
                    }
                }

            }
            
            foreach (CheckBox ingredient in SirenaGB.Controls)
            {
                if (srednoRADBTN.Checked == true)
                {
                    if (ingredient.Checked == true)
                    {
                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.05, "ingridient"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.1, "ingridient"));
                        }

                    }
                    
                }
                else
                {

                    if (ingredient.Checked == true)
                    {

                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.1, "ingridient"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.1, "ingridient"));
                        }
                    }
                }

            }
            
            foreach (CheckBox ingredient in MorskiDaroveGB.Controls)
            {
                if (srednoRADBTN.Checked == true)
                {
                    if (ingredient.Checked == true)
                    {
                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.05, "ingridient"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.1, "ingridient"));
                        }

                    }
                    
                }
                else
                {
                    if (ingredient.Checked == true)
                    {

                        if (isNewPasta == true)
                            poruchka.Items.Last().Ingridients.Add(new Ingridient(ingredient.Text, 0.1, "ingridient"));
                        else
                        {
                            poruchka.Items[nomerNapasta].Ingridients.Add(new Ingridient(ingredient.Text, 0.1, "ingridient"));
                        }
                    }
                }
            }
        }
        private void updateCena()
        {
            CenaPastaLBL.Text = $"{cenaNaRazmer + cenaNaDobavki:F2}лв.";
        }

        private void SpagetiRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            pastaOpisanie[1] = SpagetiRADBTN.Text;
        }

        private void TaliateliRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            pastaOpisanie[1] = TaliateliRADBTN.Text;
        }

        private void MakaraniRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            pastaOpisanie[1] = MakaraniRADBTN.Text;
        }

        private void FetuchiniRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            pastaOpisanie[1] = FetuchiniRADBTN.Text;
        }

        private void ParpadeliRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            pastaOpisanie[1] = ParpadeliRADBTN.Text;
        }

        private void BolonezeRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            pastaOpisanie[2] = "с " + BolonezeRADBTN.Text;
        }

        private void CarbonaraRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            pastaOpisanie[2] = "с " + CarbonaraRADBTN.Text;
        }

        private void AlfredoRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            pastaOpisanie[2] = "с " + AlfredoRADBTN.Text;
        }

        private void MarinaraRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            pastaOpisanie[2] = "с " + MarinaraRADBTN.Text;
        }

        private void PestoRADBTN_CheckedChanged(object sender, EventArgs e)
        {
            pastaOpisanie[2] = "с " + PestoRADBTN.Text;
        }

        private void chickenCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void KuftetaCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void BeconCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void ProshutoCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void KrenvrishCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void GabiCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void CheriDomCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void BrokoliCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието
            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void SpanakCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void SushenDomCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void MocarelaCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void ChedarCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void SinoSirnCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void RikotaCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void BurataCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void TunaCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void AnshiaCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void SiomgaCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието
            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void SkaridiCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void KalmariCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox; // Взимаме референция към чекбокса, който е предизвикал събитието

            if (checkBox.Checked)
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki += 0.50;
                else
                    cenaNaDobavki += 1;
            }
            else
            {
                if (srednoRADBTN.Checked)
                    cenaNaDobavki -= 0.50;
                else
                    cenaNaDobavki -= 1; ; // Ако чекбоксът е снет, намаляваме цената с 50
            }
            updateCena();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recepta = null;
            Recepti recepti = new Recepti();
            recepti.ShowDialog();
            CheckRecepta();
        }

        private void CheckRecepta()
        {
            if (recepta != null)
            {
                foreach (CheckBox box in MesaGB.Controls)
                {
                    box.Checked = false;
                }
                foreach (CheckBox box in ZelenchuciGB.Controls)
                {
                    box.Checked = false;
                }
                foreach (CheckBox box in SirenaGB.Controls)
                {
                    box.Checked = false;
                }
                foreach (CheckBox box in MorskiDaroveGB.Controls)
                {
                    box.Checked = false;
                }
                if (recepta == "TaliBolo")
                {
                    TaliateliRADBTN.Checked = true;
                    BolonezeRADBTN.Checked = true;
                }
                else if (recepta == "SpagCarb")
                {
                    SpagetiRADBTN.Checked = true;
                    CarbonaraRADBTN.Checked = true;
                    BeconCB.Checked = true;
                }
                else if (recepta == "FetAlf")
                {
                    FetuchiniRADBTN.Checked = true;
                    AlfredoRADBTN.Checked = true;
                    chickenCB.Checked = true;
                    BrokoliCB.Checked = true;
                }
                else if (recepta == "SpagKuf")
                {
                    SpagetiRADBTN.Checked = true;
                    MarinaraRADBTN.Checked = true;
                    KuftetaCB.Checked = true;
                }
                else if (recepta == "MakPesDom")
                {
                    MakaraniRADBTN.Checked = true;
                    PestoRADBTN.Checked = true;
                    CheriDomCB.Checked = true;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
