using Microsoft.AspNetCore.Mvc;
using GadgetHub.Models;

namespace GadgetHub.DistributorPortal.Controllers
{
    public class DistributorController : Controller
    {
        // Simulate receiving quotation requests with sample data
        public IActionResult QuotationRequests()
        {
            var requests = new List<QuotationRequest>
            {
                new QuotationRequest { ProductId = 101, Quantity = 5 },
                new QuotationRequest { ProductId = 102, Quantity = 3 },
                new QuotationRequest { ProductId = 103, Quantity = 2 }
            };
            return View(requests);
        }

        // Simulate confirming orders with sample data
        public IActionResult ConfirmOrders()
        {
            var orders = new List<Order>
            {
                new Order { OrderId = 1001, CustomerId = 101, OrderDate = DateTime.Now.AddDays(-2), Status = "Pending" },
                new Order { OrderId = 1002, CustomerId = 102, OrderDate = DateTime.Now.AddDays(-1), Status = "Pending" },
                new Order { OrderId = 1003, CustomerId = 103, OrderDate = DateTime.Now.AddDays(-3), Status = "Confirmed" }
            };
            return View(orders);
        }
    }
}
