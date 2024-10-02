using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompleteSystem.OrdersSystem;

using CompleteSystem.OrdersSystem.Models;
using FastFoodSystem.OrderSystem.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace PastaMadnessSystem
{
    public partial class Razplashtane : Form
    {
        Poruchka poruchka = Poruchki.Celiporuchki[Poruchki.poziciqNaPoruchka].poruchka;
        public Razplashtane()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            tabControl1.Font = new System.Drawing.Font("Arial", 20, FontStyle.Regular);
            PoruchkaCenalbl.Text = $"{poruchka.Price:F2}лв.";
            CenaNaPorruchkaBtn.Text = $"Цената на поръчката е: {poruchka.Price:F2}лв.";
        }
        public void updateResto()
        {
            if (KlientSumalbl.Text.Length > 0)
            {
                if (!KlientSumalbl.Text.Last().Equals('.'))
                    if((double.Parse(KlientSumalbl.Text, CultureInfo.InvariantCulture) - poruchka.Price) >=0)
                    Restolbl.Text = $"{(double.Parse(KlientSumalbl.Text, CultureInfo.InvariantCulture) - poruchka.Price):f2}лв.";
                    else
                    {
                        Restolbl.Text = $"Сумата на клиента е по-малка от цената на поръчката";
                    }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(!KlientSumalbl.Text.Contains(".")||
                KlientSumalbl.Text.Substring(KlientSumalbl.Text.IndexOf('.') + 1).Length<2) 
            KlientSumalbl.Text += 1;
            updateResto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!KlientSumalbl.Text.Contains(".") ||
               KlientSumalbl.Text.Substring(KlientSumalbl.Text.IndexOf('.') + 1).Length < 2)
                KlientSumalbl.Text += 2;
            updateResto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!KlientSumalbl.Text.Contains(".") ||
               KlientSumalbl.Text.Substring(KlientSumalbl.Text.IndexOf('.') + 1).Length < 2)
                KlientSumalbl.Text += 3;
            updateResto();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!KlientSumalbl.Text.Contains(".") ||
               KlientSumalbl.Text.Substring(KlientSumalbl.Text.IndexOf('.') + 1).Length < 2)
                KlientSumalbl.Text += 4;
            updateResto();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!KlientSumalbl.Text.Contains(".") ||
               KlientSumalbl.Text.Substring(KlientSumalbl.Text.IndexOf('.') + 1).Length < 2)
                KlientSumalbl.Text += 5;
            updateResto();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!KlientSumalbl.Text.Contains(".") ||
               KlientSumalbl.Text.Substring(KlientSumalbl.Text.IndexOf('.') + 1).Length < 2)
                KlientSumalbl.Text += 6;
            updateResto();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!KlientSumalbl.Text.Contains(".") ||
               KlientSumalbl.Text.Substring(KlientSumalbl.Text.IndexOf('.') + 1).Length < 2)
                KlientSumalbl.Text += 7;
            updateResto();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!KlientSumalbl.Text.Contains(".") ||
               KlientSumalbl.Text.Substring(KlientSumalbl.Text.IndexOf('.') + 1).Length < 2)
                KlientSumalbl.Text += 8;
            updateResto();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!KlientSumalbl.Text.Contains(".") ||
               KlientSumalbl.Text.Substring(KlientSumalbl.Text.IndexOf('.') + 1).Length < 2)
                KlientSumalbl.Text += 9;
            updateResto();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (!KlientSumalbl.Text.Contains(".") ||
               KlientSumalbl.Text.Substring(KlientSumalbl.Text.IndexOf('.') + 1).Length < 2)
                KlientSumalbl.Text += 0;
            updateResto();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (!KlientSumalbl.Text.Contains('.') && KlientSumalbl.Text.Count() != 0)
                KlientSumalbl.Text += '.';
            updateResto();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (KlientSumalbl.Text.Length > 0)
            {
                StringBuilder sb = new StringBuilder(KlientSumalbl.Text);
                sb.Remove(KlientSumalbl.Text.Length - 1, 1);
                KlientSumalbl.Text = sb.ToString();
                updateResto();
            }
        }

       

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CardRazplashtaneBtn_Click(object sender, EventArgs e)
        {
            FullOrder.isRazplatena = false;
            DialogResult result = MessageBox.Show
                ("Сигурни ли сте, че искате да разплатите поръчката?", "Потвърждение на разплащане", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Poruchki.Celiporuchki.RemoveAt(Poruchki.poziciqNaPoruchka);
                FullOrder.isRazplatena = true;
                Hide();

            }
            else
            {
                FullOrder.isRazplatena = false;
            }
        }

        private void CardNazadBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void RazplashtaneBtn_Click(object sender, EventArgs e)
        {
            FullOrder.isRazplatena = false;
            DialogResult result = MessageBox.Show
                ("Сигурни ли сте, че искате да разплатите поръчката?", "Потвърждение на разплащане", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Poruchka poruchka = Poruchki.Celiporuchki.ElementAt(Poruchki.poziciqNaPoruchka).poruchka;
                using (var db = new OrderDbContext())
                {
                    PoruchkaEntity poruchkaEntity = new PoruchkaEntity(poruchka.Price, new List<ItemEntity>());
                    poruchkaEntity.Type = poruchka.type;
                    foreach (var item in poruchka.Items)
                    {
                        poruchkaEntity.Items.Add(new ItemEntity(item.Name, item.Price, item.Quantity, item.Type));
                        

                        foreach (var ingridient in item.Ingridients)
                        {
                            poruchkaEntity.Items.Last().Ingridients.Add(new IngridientEntity(ingridient.Name, ingridient.Kg, ingridient.Type));
                        }
                        if (item.Type != "Pasta")
                        {
                            db.Elements.Where(x => x.Name == item.Name).FirstOrDefault().Quantity -= item.Quantity;
                        }
                        else
                        {
                            foreach(var ingridient in item.Ingridients)
                            {
                                if(ingridient.Type == "Pasta")
                                {
                                    db.Elements.Where(x => x.Name == "Семола").FirstOrDefault().Kg -= ingridient.Kg * item.Quantity;
                                }
                                else
                                {
                                    if( ingridient.Name == "Болонезе сос")
                                    {
                                        db.Elements.Where(x => x.Name == "Смачкани домати").FirstOrDefault().Kg -= ingridient.Kg/4*item.Quantity;
                                        db.Elements.Where(x => x.Name == "Кайма").FirstOrDefault().Kg -= ingridient.Kg / 2 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "Лук").FirstOrDefault().Kg -= ingridient.Kg / 10 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "Морков").FirstOrDefault().Kg -= ingridient.Kg / 10 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "Целина").FirstOrDefault().Kg -= ingridient.Kg / 10 * item.Quantity;
                                    }
                                    else if( ingridient.Name =="Алфредо сос")
                                    {
                                        db.Elements.Where(x => x.Name == "масло").FirstOrDefault().Kg -= ingridient.Kg / 4 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "сметана").FirstOrDefault().Kg -= ingridient.Kg / 2 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "пармезан").FirstOrDefault().Kg -= ingridient.Kg / 4 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "Чесън").FirstOrDefault().Kg -= ingridient.Kg / 10 * item.Quantity;
                                    }
                                    else if (ingridient.Name == "Маринара сос")
                                    {
                                        db.Elements.Where(x => x.Name == "Смачкани домати").FirstOrDefault().Kg -= ingridient.Kg / 4 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "Босилек").FirstOrDefault().Kg -= ingridient.Kg / 2 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "Лук").FirstOrDefault().Kg -= ingridient.Kg / 4 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "Чесън").FirstOrDefault().Kg -= ingridient.Kg / 10 * item.Quantity;
                                    }
                                    else if(ingridient.Name == "Песто сос")
                                    {
                                        db.Elements.Where(x => x.Name == "Босилек").FirstOrDefault().Kg -= ingridient.Kg / 2 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "Фастъци").FirstOrDefault().Kg -= ingridient.Kg / 2 * item.Quantity;
                                        db.Elements.Where(x => x.Name == "Пармензан").FirstOrDefault().Kg -= ingridient.Kg / 2 * item.Quantity;
                                    }
                                    else if(ingridient.Name == "Кюфтенца")
                                    {
                                        db.Elements.Where(x => x.Name == "Кайма").FirstOrDefault().Kg -= ingridient.Kg * item.Quantity;
                                    }
                                    else
                                    {
                                        db.Elements.Where(x => x.Name == ingridient.Name).FirstOrDefault().Kg -= ingridient.Kg * item.Quantity;
                                    }
                                }
                            }
                        }
                    }


                    db.Poruchki.Add(poruchkaEntity);
                    db.SaveChanges();
                }
                Poruchki.Celiporuchki.RemoveAt(Poruchki.poziciqNaPoruchka);
                FullOrder.isRazplatena = true;
                Hide();

            }
            else
            {
                FullOrder.isRazplatena = false;
            }
        }
    }
}
