using BeeShopMVC.Data.Models;
using System.Collections.Generic;

namespace BeeShopMVC.Data.Seeders
{
    public class HoneySeeder
    {
        public ICollection<Honey> GenerateHoney()
        {
            HashSet<Honey> honey = new HashSet<Honey>();
            Honey currentHoney = null;

            currentHoney = new Honey()
            {
                Id = 1,
                Name = "Мед от манаука",
                Description = "blablablabllbalabalbla",
                Price = 19.29
            };
            honey.Add(currentHoney);
            currentHoney = new Honey()
            {
                Id = 2,
                Name = "Български златен нектар",
                Description = "blablablabllbalabalbla",
                Price = 25.29
            };
            honey.Add(currentHoney);

            currentHoney = new Honey()
            {
                Id = 3,
                Name = "Манов мед",
                Description = "blablablabllbalabalbla",
                Price = 15.29
            };
            honey.Add(currentHoney);
            return honey;
        }
    }
}
