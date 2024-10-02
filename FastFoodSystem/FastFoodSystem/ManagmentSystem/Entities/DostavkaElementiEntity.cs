using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSystem.ManagmentSystem.Entities
{
    public class DostavkaElementiEntity
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Kg { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public int DostavkaEntityId { get; set; }
        public DostavkaEntity dostavka { get; set; }
        public DostavkaElementiEntity(string name, string type, int quantity, double kg)
        {
            Name = name;
            Type = type;
            Quantity = quantity;
            Kg = kg;
        }
        public DostavkaElementiEntity()
        {

        }
    }
}
