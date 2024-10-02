using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteSystem.OrdersSystem.Models
{
    public class Item
    {
        public List<Ingridient> Ingridients { get; set; }
        public Button plus { get; set; }
        public Button minus { get; set; }
        public Button Remove { get; set; }
        public Button Edit { get; set; }

        public string Type { get; set; }
        public Form PastaForm { get; set; }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double totalSum;

        public void UpdateTotalSum()
        {
            totalSum = Price * Quantity;
        }

        public Item(string name, double price, string type)
        {
            Name = name;
            Price = price;
            Ingridients = new List<Ingridient>();

            Quantity = 1;
            totalSum = Price * Quantity;

            plus = new Button();
            plus.Text = "+";
            plus.AutoSize = true;
            plus.Font = new Font("Arial", 20);


            minus = new Button(); minus.Text = "-";
            minus.AutoSize = true;
            minus.Font = new Font("Arial", 20);

            Remove = new Button(); Remove.Text = "X";
            Remove.AutoSize = true;
            Remove.Font = new Font("Arial", 20);

            Edit = new Button(); Edit.Text = "edit";
            Edit.AutoSize = true;
            Edit.Font = new Font("Arial", 20);
            Type = type;
        }
        public int PoruchkaId { get; set; } // Foreign key
        public Poruchka poruchka { get; set; } // Navigation property

    }
}
