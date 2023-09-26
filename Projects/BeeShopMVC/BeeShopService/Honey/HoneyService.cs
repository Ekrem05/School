using BeeShop.Services.Interfaces;
using BeeShop.Web.ViewModel;
using BeeShopMVC.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeShop.Services.Honey
{
    public class HoneyService : IHoneyService
    {
        private readonly BeeShopDbContext con;
        public HoneyService(BeeShopDbContext con)
        {
            this.con = con; 
        }
        public async Task<IEnumerable<HoneyListViewModel>> ListAllAsync()
        {
            IEnumerable<HoneyListViewModel> allHoney = await con
                .Honey
                .Select(h => new HoneyListViewModel()
                {
                    Id = h.Id.ToString(),
                    Name = h.Name.ToString(),
                    Description = h.Description.ToString(),
                    Pirce = h.Price
                }).ToArrayAsync();

            return allHoney;
            
        }
    }
}
