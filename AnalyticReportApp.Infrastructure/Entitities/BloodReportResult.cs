using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class BloodReportResult
    {
        public long Id { get; set; }
        public long PatientId { get; set; }
        public string? TestGroup { get; set; }
        public string? Test { get; set; }
        public string? Result { get; set; }
        public string? Flag { get; set; }
        public string? Units { get; set; }
        public string? ReferenceInterval { get; set; }
        public string? Lab { get; set; }
    }
}
