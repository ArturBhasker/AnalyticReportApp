using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class Resource
    {
        public string Id { get; set; } = null!;
        public long? ResourceId { get; set; }
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public long? ResourceType { get; set; }
        public byte[]? Cost { get; set; }
        public string? UnitOfMeasure { get; set; }
    }
}
