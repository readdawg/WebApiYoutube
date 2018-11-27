using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiYoutube.Models;

namespace WebApiYoutube.Services
{
    public interface IInventoryServices
    {
        object AddInventoryItems(InventoryItems items);
    }
}
