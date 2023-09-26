using BeeShop.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeShop.Services.Interfaces
{
    public interface IHoneyService
    {
        Task<IEnumerable<HoneyListViewModel>> ListAllAsync();
    }
}
