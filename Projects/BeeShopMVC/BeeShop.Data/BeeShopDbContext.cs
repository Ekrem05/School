
using BeeShopMVC.Data.Configurations;
using BeeShopMVC.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BeeShopMVC.Data
{
    public class BeeShopDbContext : DbContext
    {
        public BeeShopDbContext(DbContextOptions<BeeShopDbContext> options) : base(options)
        {
        }
        public DbSet<Honey> Honey { get; init; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
           modelBuilder.ApplyConfiguration(new HoneyEntityConfiguration()); 
            base.OnModelCreating(modelBuilder);
        }
        
        

       

    }
}
