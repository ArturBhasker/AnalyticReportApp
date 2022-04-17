using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class SystemAdaptability
    {
        public long Id { get; set; }
        public string? Adaptability { get; set; }
        public byte[]? NewTransport { get; set; }
        public double? Otis { get; set; }
        public byte[]? MobileWalk { get; set; }
    }
}
