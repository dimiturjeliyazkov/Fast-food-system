using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSystem.ManagmentSystem.Entities
{
    public class DostavkaEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DostavkaElementiEntity> Stuff { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DostavkaDate { get; set; }
        
        public DostavkaEntity()
        {
                
        }
        
    }
}
