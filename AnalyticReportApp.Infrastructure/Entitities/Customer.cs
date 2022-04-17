using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class Customer
    {
        public string? UserCode { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Company { get; set; }
        public byte[]? Contacted { get; set; }
        public byte[]? Phone { get; set; }
        public long? CustType { get; set; }
    }
}
