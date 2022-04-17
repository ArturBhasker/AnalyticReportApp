using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class Detail
    {
        public string? ItemId { get; set; }
        public string? Description { get; set; }
        public byte[]? DealerCost { get; set; }
        public byte[]? Msrp { get; set; }
    }
}
