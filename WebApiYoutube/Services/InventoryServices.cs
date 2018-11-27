using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiYoutube.Models;

namespace WebApiYoutube.Services
{
    public class InventoryServices : IInventoryServices
    {

        private readonly Dictionary<string, InventoryItems> _inventoryItems;
        
        public InventoryServices()
        {

            _inventoryItems = new Dictionary<string, InventoryItems>();
        }

        public InventoryItems AddInventoryItems(InventoryItems items)
        {

            _inventoryItems.Add(items.ItemName, items);

            return items;
        }
    }
}
