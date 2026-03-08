using Microsoft.AspNetCore.Mvc;
using GadgetHub.Models;

namespace GadgetHub.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuotationsController : ControllerBase
    {
        // Simulate distributor quotation responses
        [HttpPost]
        public ActionResult<List<QuotationResponse>> GetQuotations([FromBody] List<QuotationRequest> requests)
        {
            var distributors = new[] { "TechWorld", "ElectroCom", "Gadget Central" };
            var responses = new List<QuotationResponse>();
            var rand = new Random();
            foreach (var req in requests)
            {
                foreach (var dist in distributors)
                {
                    responses.Add(new QuotationResponse
                    {
                        ProductId = req.ProductId,
                        PricePerUnit = rand.Next(100, 1000),
                        AvailableQuantity = rand.Next(1, 20),
                        EstimatedDeliveryDays = rand.Next(2, 7),
                        DistributorName = dist
                    });
                }
            }
            return Ok(responses);
        }
    }
}
