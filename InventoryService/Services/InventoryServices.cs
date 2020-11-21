using InventoryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService.Services
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

        public Dictionary<string, InventoryItems> GetInventoryitems()
        {
            return _inventoryItems;
        }
    }
}
