using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSystem.ManagmentSystem.Entities
{
    public class SkrapEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SkrapElementiEntity> Stuff { get; set; }
        public double TotalPrice { get; set; }
        public DateTime SkrapDate { get; set; }

        public SkrapEntity()
        {

        }
    }
}
