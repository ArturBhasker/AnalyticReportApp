namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class PatientTestResult
    {
        public long RowId { get; set; }
        public long? PatientId { get; set; }
        public string? AllergenCategory { get; set; }
        public string? AllergenName { get; set; }
        public string? Result { get; set; }
        public long? ResultValue { get; set; }
        public string? InsignificantValue { get; set; }
        public string? ModerateValue { get; set; }
        public string? SignificantValue { get; set; }
        public long? InsignificantValue2 { get; set; }
        public long? ModerateValue2Min { get; set; }
        public long? ModerateValue2Max { get; set; }
        public long? SignificantValue2 { get; set; }
    }
}
