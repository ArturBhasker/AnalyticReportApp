using System;
using System.Collections.Generic;

namespace AnalyticReportApp.Infrastructure
{
    public partial class PatientInfo
    {
        public long PatientId { get; set; }
        public string? PatientNo { get; set; }
        public string? PatientName { get; set; }
        public string? PatientDoctor { get; set; }
        public string? Fax { get; set; }
        public string? DoctorId { get; set; }
        public string? DataFile { get; set; }
        public string? Technician { get; set; }
        public byte[]? DateCollected { get; set; }
        public byte[]? DateReceived { get; set; }
        public byte[]? DateRun { get; set; }
        public byte[]? DateReported { get; set; }
        public string? Comments { get; set; }
    }
}
