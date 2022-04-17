using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class Composer
    {
        public string? First { get; set; }
        public string? Last { get; set; }
        public string? Country { get; set; }
        public byte[]? Birth { get; set; }
        public byte[]? Death { get; set; }
    }
}
