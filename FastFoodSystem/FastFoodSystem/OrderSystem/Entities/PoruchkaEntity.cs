using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSystem.OrderSystem.Entities
{

    public class PoruchkaEntity
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime OrderDate { get; set; }
        public double Price { get; set; }
        public List<ItemEntity> Items { get; set; }

        // Конструктор за инициализация на свойствата на PoruchkaEntity
        public PoruchkaEntity(double price, List<ItemEntity> items)
        {

            OrderDate = DateTime.Now;
            Price = price;
            Items = items;
        }

        // Празен конструктор за Entity Framework
        public PoruchkaEntity()
        {
            Items = new List<ItemEntity>();
        }
    }
}
