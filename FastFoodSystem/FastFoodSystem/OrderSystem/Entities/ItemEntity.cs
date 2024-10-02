using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastFoodSystem.OrderSystem.Entities
{
    [Table("Items")]
    public class ItemEntity
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Type { get; set; }
        public int Quantity { get; set; }
        public List<IngridientEntity> Ingridients { get; set; }

        public int PoruchkaId { get; set; }

        // Navigation property for Poruchka
        [ForeignKey("PoruchkaId")]
        public PoruchkaEntity PoruchkaEntity { get; set; }

        // Empty constructor required by EF Core
        

        // Constructor without PoruchkaEntity parameter
        public ItemEntity(string name, double price, int quantity, string type)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Ingridients = new List<IngridientEntity>();
            Type = type;
        }
        public ItemEntity()
        {
                
        }
    }
}
