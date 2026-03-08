using Microsoft.AspNetCore.Mvc;
using GadgetHub.Models;

namespace GadgetHub.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        // In-memory order list for demo
        private static List<Order> orders = new List<Order>();

        [HttpPost]
        public ActionResult<Order> PlaceOrder([FromBody] Order order)
        {
            order.OrderId = orders.Count + 1;
            order.OrderDate = DateTime.UtcNow;
            order.Status = "Pending";
            orders.Add(order);
            return Ok(order);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAll()
        {
            return Ok(orders);
        }
    }
}
