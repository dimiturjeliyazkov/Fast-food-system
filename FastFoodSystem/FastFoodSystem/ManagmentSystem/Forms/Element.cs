using FastFoodSystem.ManagmentSystem.Entities;
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
    public partial class Element : Form
    {
        ICollection<ElementEntity> elements;
        public Element(ICollection<ElementEntity> elements)
        {

            InitializeComponent();
            this.elements = elements;   
        }

        private void NazadBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void ZapaziBtn_Click(object sender, EventArgs e)
        {
            
            elements.Add(new ElementEntity(ImeTxt.Text, TipComboBox.SelectedItem.ToString(), 0, 0));
            
            Hide();
        }
    }
}
