using BeeShopMVC.Data.Interfaces;
using BeeShopMVC.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BeeShopMVC.Data
{
    public class BeeShopDbContext : DbContext
    {
        public BeeShopDbContext(DbContextOptions<BeeShopDbContext> options) : base(options)
        {
            Database.Migrate();
        }
        DbSet<Honey> Honey { get; init; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedHoney();
            modelBuilder.Entity<Honey>().HasData(SunFlowerHoney,ManHoney,ManaukaHoney);
            base.OnModelCreating(modelBuilder);
        }
        private Honey SunFlowerHoney { get; set; }
        private Honey ManHoney { get; set; }
        private Honey ManaukaHoney { get; set; }
        private void SeedHoney()
        {
            SunFlowerHoney = new Honey
            {
                Id = 1,
                Name = "Български златен нектар",
                Description = "blablablabllbalabalbla",
                Price = 15.29

            };
            ManHoney = new Honey
            {
                Id = 2,
                Name = "Манов мед",
                Description = "blablablabllbalabalbla",
                Price = 17.29

            };
            ManaukaHoney = new Honey
            {
                Id = 3,
                Name = "Мед от манаука",
                Description = "blablablabllbalabalbla",
                Price = 25.29

            };
        }

        //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BeeShopMVC;Integrated Security=True;");

    }
}
