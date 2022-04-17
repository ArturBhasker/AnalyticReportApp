using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class Order
    {
        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? ProductId { get; set; }
        public byte[]? PurchaseDate { get; set; }
        public byte[]? Time { get; set; }
        public string? PaymentType { get; set; }
        public byte[]? PaymentAmount { get; set; }
        public string? Description { get; set; }
        public long? Quantity { get; set; }
    }
}
