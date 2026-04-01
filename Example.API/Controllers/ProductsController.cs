using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.API.Controllers
{
    // Attribute based routing
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //endpoint: GET api/products

        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok("kalem 1");
        }

        [HttpPost]
        public IActionResult CreateProduct()
        {
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateProduct()
        {
            return NoContent();
        }

        [HttpPatch]
        public IActionResult UpdateProductName()
        {
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteProduct()
        {
            return NoContent();
        }
    }
}
