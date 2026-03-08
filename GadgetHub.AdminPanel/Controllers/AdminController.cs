using Microsoft.AspNetCore.Mvc;
using GadgetHub.Models;
using System.Globalization;

namespace GadgetHub.AdminPanel.Controllers
{
    public class AdminController : Controller
    {
        // Admin dashboard
        public IActionResult Dashboard()
        {
            return View();
        }

        // Simulate viewing all orders with sample data
        public IActionResult Orders()
        {
            var orders = new List<Order>
            {
                new Order { OrderId = 1001, CustomerId = 101, OrderDate = DateTime.Now.AddDays(-2), Status = "Pending" },
                new Order { OrderId = 1002, CustomerId = 102, OrderDate = DateTime.Now.AddDays(-1), Status = "Confirmed" },
                new Order { OrderId = 1003, CustomerId = 103, OrderDate = DateTime.Now.AddDays(-3), Status = "Shipped" },
                new Order { OrderId = 1004, CustomerId = 104, OrderDate = DateTime.Now.AddDays(-5), Status = "Delivered" }
            };
            return View(orders);
        }

        // Simulate viewing all products with sample data
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

        // Add product form
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        // Handle add product post
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            // In a real app, save to database
            // For demo, redirect to products
            return RedirectToAction("Products");
        }

        // Manage customers with sample data
        public IActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 101, Name = "John Smith", Email = "john.smith@email.com" },
                new Customer { Id = 102, Name = "Sarah Johnson", Email = "sarah.johnson@email.com" },
                new Customer { Id = 103, Name = "Michael Brown", Email = "michael.brown@email.com" },
                new Customer { Id = 104, Name = "Emily Davis", Email = "emily.davis@email.com" }
            };
            return View(customers);
        }
    }
}
