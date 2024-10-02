using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSystem.ManagmentSystem.Entities
{
    public class DostavchikEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public virtual ICollection<ElementEntity> Elements { get; set; }
        public DostavchikEntity(string name, string descr, ICollection<ElementEntity> elements)
        {
            Name = name;
            Description = descr;
            Elements = elements;
        }
        public DostavchikEntity()
        {
           
        }
    }
}
