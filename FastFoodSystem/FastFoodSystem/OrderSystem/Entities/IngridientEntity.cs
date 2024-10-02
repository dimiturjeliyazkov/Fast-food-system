using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSystem.OrderSystem.Entities
{
    public class IngridientEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string type { get; set; }
        public double Kg { get; set; }
        public IngridientEntity(string name, double kg, string type)
        {
            Name = name;
            Kg = kg;
            this.type = type;
        }
    }
}
