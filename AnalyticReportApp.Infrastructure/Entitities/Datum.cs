using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class Datum
    {
        public byte[]? Id { get; set; }
        public string? Company { get; set; }
        public byte[]? Cost { get; set; }
        public byte[]? Qt { get; set; }
        public byte[]? Sum { get; set; }
        public string? Model { get; set; }
    }
}
