using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PastaMadnessSystem
{
    public partial class Recepti : Form
    {
        public Recepti()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void TaglaBolBtn_Click(object sender, EventArgs e)
        {
            Pasta.recepta = "TaliBolo";
            Hide();
        }

        private void SpagCarbBtn_Click(object sender, EventArgs e)
        {
            Pasta.recepta = "SpagCarb";
            Hide();
        }

        private void FetchAlfterd_Click(object sender, EventArgs e)
        {
            Pasta.recepta = "FetAlf";
            Hide();
        }

        private void SpagSKufBtn_Click(object sender, EventArgs e)
        {
            Pasta.recepta = "SpagKuf";
            Hide();
        }

        private void MakSPestoIchrBtn_Click(object sender, EventArgs e)
        {
            Pasta.recepta = "MakPesDom";
            Hide();
        }
    }
}
