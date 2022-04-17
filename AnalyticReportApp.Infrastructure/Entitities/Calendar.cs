using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class Calendar
    {
        public string Id { get; set; } = null!;
        public long? CalendarId { get; set; }
        public string? Name { get; set; }
        public string? Data { get; set; }
    }
}
