using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using web_ml.Services;

namespace web_ml.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ItemsService _service;

        public ItemsController(ItemsService service)
        {
            _service = service;
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Items(string id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var result = await _service.GetItems(id);
                    
                    return Json(new { Cartas = id });
                }
                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest(httpRequestException.Message);
                }
            }          
        }
    }
}