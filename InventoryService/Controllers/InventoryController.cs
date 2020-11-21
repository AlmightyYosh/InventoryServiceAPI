using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryService.Models;
using InventoryService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryServices _services;

        public InventoryController(IInventoryServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("AddInventoryItems")]
        public ActionResult<InventoryItems> AddInventoryItems(InventoryItems items)
        {
            
            var InventoryItems = _services.AddInventoryItems(items);
            if(InventoryItems == null)
            {
                return NotFound();
            }
            
            return InventoryItems;

            //<InventoryItems> retuns that model to this method.

        }

        [HttpGet]
        [Route("GetInventoryitems")]
        public ActionResult<Dictionary<string, InventoryItems>> GetInventoryItems()
        {
            var inventoryItems = _services.GetInventoryitems();

            if(inventoryItems.Count == 0)
            {
                return NotFound();
            }
            
            return inventoryItems;
        }

    }
}
