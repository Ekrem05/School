using BeeShop.Services.Interfaces;
using BeeShop.Web.ViewModel;
using BeeShopMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace BeeShopMVC.Controllers
{
    public class HoneyController : Controller
    {
        private readonly IHoneyService honeyService;
            public HoneyController(IHoneyService honeyService)
            {
            this.honeyService = honeyService;
            }
        public async Task<IActionResult> All()
        {
            IEnumerable<HoneyListViewModel> allHoney=await
                this.honeyService.ListAllAsync();
           return View(allHoney);
        }
           
    }
}
