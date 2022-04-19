namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class BloodReportPatientInfo
    {
        public long PatientId { get; set; }
        public string? PatientNo { get; set; }
        public string? AccountNo { get; set; }
        public string? SpecimanNo { get; set; }
        public string? ControlNo { get; set; }
        public string? PatientFname { get; set; }
        public string? PatientMname { get; set; }
        public string? PatientLname { get; set; }
        public string? PatientSex { get; set; }
        public string? Age { get; set; }
        public string? Fasting { get; set; }
        public string? PatientDoctor { get; set; }
        public string? Fax { get; set; }
        public string? DoctorId { get; set; }
        public string? DataFile { get; set; }
        public string? Technician { get; set; }
        public byte[]? DateCollected { get; set; }
        public byte[]? DateEntered { get; set; }
        public byte[]? DateReported { get; set; }
        public byte[]? Dob { get; set; }
        public string? Comments { get; set; }
    }
}
