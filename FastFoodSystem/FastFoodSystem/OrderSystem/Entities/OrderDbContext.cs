
using FastFoodSystem.ManagmentSystem.Entities;
using System.Data.Entity;


namespace FastFoodSystem.OrderSystem.Entities
{
    
    public class OrderDbContext : DbContext
    {

        public OrderDbContext() : base("name=YourDbContextConnectionString")
        {
            Configuration.LazyLoadingEnabled = true; // Enable lazy loading
        }
        public DbSet<ItemEntity> Items { get; set; }
        public DbSet<PoruchkaEntity> Poruchki { get; set; }
        public DbSet<IngridientEntity> Ingridients { get; set; }
        public DbSet<DostavchikEntity> Dostavchici { get; set; }
        public DbSet<ElementEntity> Elements { get; set; }
        public DbSet<DostavkaEntity> Dostavki { get; set; } 
        public DbSet<SkrapEntity> Skrapki { get; set; } 
        public DbSet<SkrapElementiEntity> SkrapElements { get; set; }   
    }
}
