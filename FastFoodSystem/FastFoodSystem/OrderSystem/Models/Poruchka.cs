using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteSystem.OrdersSystem.Models
{
    public class Poruchka
    {
        public int PoruckaNomer { get; set; }

        public string type { get; set; }

        private static int nextId = 1;
        public double Price { get; set; }
        public List<Item> Items { get; set; }

        public Poruchka()
        {
            Items = new List<Item>();

            PoruckaNomer = nextId++;
        }

        public void UpdateTotalPrice()
        {
            Price = Items.Sum(item => item.totalSum);
        }
    }
}
