namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class EmployeeTravelExp
    {
        public long ExpId { get; set; }
        public string? EmpName { get; set; }
        public string? DescOfExp { get; set; }
        public byte[]? DateFrom { get; set; }
        public byte[]? DateTo { get; set; }
        public byte[]? DateofSubmission { get; set; }
        public string? AutherisedBy { get; set; }
        public long? Airfare { get; set; }
        public long? Lodging { get; set; }
        public long? GroundTransportation { get; set; }
        public long? MealsTips { get; set; }
        public long? ConferencesSeminars { get; set; }
        public long? Miles { get; set; }
        public long? MileageReimbursement { get; set; }
        public long? Miscellaneous { get; set; }
        public long? CurrExchangeRate { get; set; }
        public string? ExpenceCurr { get; set; }
        public string? Dept { get; set; }
    }
}
