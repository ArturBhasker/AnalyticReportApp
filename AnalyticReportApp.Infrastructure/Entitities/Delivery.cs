using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class Delivery
    {
        public long OrderNo { get; set; }
        public string? Address { get; set; }
        public string? Result { get; set; }
    }
}
