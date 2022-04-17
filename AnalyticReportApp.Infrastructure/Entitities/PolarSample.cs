using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class PolarSample
    {
        public long Id { get; set; }
        public long? Angle { get; set; }
        public long? Value1 { get; set; }
        public long? Value2 { get; set; }
    }
}
