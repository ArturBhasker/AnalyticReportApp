using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class Car
    {
        public long Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public long? Hp { get; set; }
        public double Liter { get; set; }
        public long? Cyl { get; set; }
        public long? TransmissSpeedCount { get; set; }
        public string? TransmissAutomatic { get; set; }
        public long? MpgCity { get; set; }
        public long? MpgHighway { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public string? Hyperlink { get; set; }
        public string? Picture { get; set; }
        public byte[]? Price { get; set; }
    }
}
