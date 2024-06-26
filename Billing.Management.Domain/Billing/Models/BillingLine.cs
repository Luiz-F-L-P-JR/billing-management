﻿
using System.Text.Json.Serialization;

namespace Billing.Management.Domain.Billing.Models
{
    public sealed class BillingLine
    {
        public Guid Id { get; set; }
        public Guid BillingId { get; set; }
        public Guid ProductId { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }

        [JsonPropertyName("unit_price")]
        public decimal UnitPrice { get; set; }

        public decimal Subtotal { get; set; }

        public BillingLine()
        {
            
        }

        public BillingLine(Guid productId, string? description, int quantity, decimal unitPrice)
        {
            ProductId = productId;
            Description = description;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Subtotal = (unitPrice * quantity);
        }
    }
}
