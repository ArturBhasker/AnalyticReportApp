using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class Photo
    {
        public long PhotoId { get; set; }
        public string? Place { get; set; }
        public string? Photo1 { get; set; }
        public string? Author { get; set; }
        public string? Country { get; set; }
    }
}
