using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteSystem.OrdersSystem.Models
{
    public class Ingridient
    {
        public string Name { get; set; }
        public double Kg { get; set; }
        public string Type { get; set; }
        public Ingridient(string name, double kg, string type)
        {
            Name = name;
            Kg = kg;
            Type = type;    
        }
    }
}
