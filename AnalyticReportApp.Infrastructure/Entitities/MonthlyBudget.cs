using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class MonthlyBudget
    {
        public long Id { get; set; }
        public string? TranType { get; set; }
        public string? TranName { get; set; }
        public long? EstimatedValue { get; set; }
        public long? ActualValue { get; set; }
        public string? TranMainType { get; set; }
    }
}
