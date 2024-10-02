using CompleteSystem.ManagmentSystem.Forms;
using PastaMadnessSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodSystem
{
    public partial class Form1 : Form
    {
        public static Poruchki poruchki = new Poruchki();
        
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }



        

        private void UpravlenieBtn_Click(object sender, EventArgs e)
        {
            InitialForm InitialForm = new InitialForm();
            InitialForm.Show();
            this.Hide();
        }

        private void PoruchkiBtn_Click(object sender, EventArgs e)
        {

            poruchki.Show();
            this.Hide();
        }
    }
}
