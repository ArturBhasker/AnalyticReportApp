using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class AtbillReport
    {
        public long BillingId { get; set; }
        public string? CustomerName { get; set; }
        public byte[]? PreviousBill { get; set; }
        public byte[]? CurrentCharges { get; set; }
        public string? AccNo { get; set; }
        public byte[]? BillingDate { get; set; }
        public byte[]? DueDate { get; set; }
        public byte[]? WireLessCharge { get; set; }
        public byte[]? Tvcharge { get; set; }
        public byte[]? VoiceCharge { get; set; }
        public string? Area { get; set; }
        public string? AreaCode { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
    }
}
