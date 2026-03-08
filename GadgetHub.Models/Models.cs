using System;
using System.Collections.Generic;
namespace GadgetHub.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class QuotationRequest
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }

    public class QuotationResponse
    {
        public int ProductId { get; set; }
        public decimal PricePerUnit { get; set; }
        public int AvailableQuantity { get; set; }
        public int EstimatedDeliveryDays { get; set; }
        public string DistributorName { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
    }

    public class OrderItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string DistributorName { get; set; }
        public decimal PricePerUnit { get; set; }
    }

    public class Distributor
    {
        public string Name { get; set; }
        public string ApiEndpoint { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
