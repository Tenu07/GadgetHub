using Microsoft.AspNetCore.Mvc;
using GadgetHub.Models;

namespace GadgetHub.CustomerPortal.Controllers
{
    public class CustomerController : Controller
    {
        // Simulate browsing products with sample data
        public IActionResult Products()
        {
            var products = new List<Product>
            {
                new Product { Id = 101, Name = "iPhone 15 Pro", Description = "Latest Apple smartphone with advanced camera system", Price = 999.00m },
                new Product { Id = 102, Name = "Samsung Galaxy S24", Description = "Flagship Android smartphone with powerful processor", Price = 899.00m },
                new Product { Id = 103, Name = "MacBook Air M2", Description = "Ultra-thin laptop with Apple M2 chip", Price = 1199.00m },
                new Product { Id = 104, Name = "iPad Pro", Description = "Professional tablet with M2 chip and Liquid Retina XDR display", Price = 1099.00m }
            };
            return View(products);
        }

        // Simulate placing an order
        public IActionResult PlaceOrder()
        {
            return View();
        }

        // Simulate viewing order status with sample data
        public IActionResult Orders()
        {
            var orders = new List<Order>
            {
                new Order { OrderId = 1001, OrderDate = DateTime.Now.AddDays(-2), Status = "Pending" },
                new Order { OrderId = 1002, OrderDate = DateTime.Now.AddDays(-1), Status = "Confirmed" },
                new Order { OrderId = 1003, OrderDate = DateTime.Now.AddDays(-5), Status = "Delivered" }
            };
            return View(orders);
        }
    }
}
