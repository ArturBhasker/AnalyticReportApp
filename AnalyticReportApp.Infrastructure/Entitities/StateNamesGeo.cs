using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class StateNamesGeo
    {
        public long Id { get; set; }
        public string? StateName { get; set; }
        public string? Abbr { get; set; }
        public string? Country { get; set; }
        public string? Comment { get; set; }
        public byte[]? Latitude { get; set; }
        public byte[]? Longitude { get; set; }
    }
}
