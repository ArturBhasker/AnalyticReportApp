using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class InventoryManagement
    {
        public long? SalesId { get; set; }
        public string? ItemCategory { get; set; }
        public string? ItemName { get; set; }
        public long? QtySold { get; set; }
        public byte[]? SoldDate { get; set; }
        public long? NetRevenue { get; set; }
        public string? CustomerName { get; set; }
    }
}
