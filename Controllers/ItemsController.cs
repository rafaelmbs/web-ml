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

        [HttpGet("/api/[controller]")]
        public async Task<IActionResult> Items(string search)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var result = await _service.GetItems(search);
                    
                    return Json(new { result = result });
                }
                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest(httpRequestException.Message);
                }
            }          
        }

        [HttpGet("/api/[controller]/{id}")]
        public async Task<IActionResult> ItemDetail(string id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var result = await _service.GetItemDetail(id);
                    
                    return Json(new { itemdetail = result });
                }
                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest(httpRequestException.Message);
                }
            }
        }

        [HttpGet("/api/[controller]/{id}/description")]
        public async Task<IActionResult> ItemDescription(string id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var result = await _service.GetItemDescription(id);

                    return Json(new { itemdescription = result });
                }
                catch (HttpRequestException httpRequestException)
                {
                    return BadRequest(httpRequestException.Message);
                }
            }
        }
    }
}