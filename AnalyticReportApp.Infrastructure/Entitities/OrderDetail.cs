using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class OrderDetail
    {
        public long? OrderId { get; set; }
        public long ProductId { get; set; }
        public byte[] UnitPrice { get; set; } = null!;
        public long Quantity { get; set; }
        public byte[] Discount { get; set; } = null!;
    }
}
