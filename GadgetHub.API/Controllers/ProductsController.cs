using Microsoft.AspNetCore.Mvc;
using GadgetHub.Models;

namespace GadgetHub.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // In-memory product list for demo
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Smartphone", Description = "Latest smartphone", Price = 699 },
            new Product { Id = 2, Name = "Tablet", Description = "High-end tablet", Price = 499 },
            new Product { Id = 3, Name = "Smartwatch", Description = "Feature-rich smartwatch", Price = 199 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return Ok(product);
        }
    }
}
