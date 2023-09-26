using BeeShopMVC.Data.Models;
using BeeShopMVC.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeeShopMVC.Data.Configurations
{
    public class HoneyEntityConfiguration : IEntityTypeConfiguration<Honey>
    {
        private readonly HoneySeeder honeySeeder;
        public HoneyEntityConfiguration()
        {
            honeySeeder= new HoneySeeder();
        }
        public void Configure(EntityTypeBuilder<Honey> builder)
        {
            builder.HasData(honeySeeder.GenerateHoney());
        }
    }
}
