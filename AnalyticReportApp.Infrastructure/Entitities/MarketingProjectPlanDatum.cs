using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class MarketingProjectPlanDatum
    {
        public long TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? TaskStatus { get; set; }
        public string? TaskOwner { get; set; }
        public string? AssignTo { get; set; }
        public byte[]? AnticipatedStartDate { get; set; }
        public byte[]? AnticipatedEndDate { get; set; }
        public byte[]? ActualStartDate { get; set; }
        public byte[]? ActualEndDate { get; set; }
        public long? EstimatedCost { get; set; }
        public long? ActualCost { get; set; }
    }
}
