namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class TelephoneBill
    {
        public long BillingId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? BillCycle { get; set; }
        public byte[]? PreviousBill { get; set; }
        public long? PaymentReceived { get; set; }
        public long? Adjustments { get; set; }
        public long? Balance { get; set; }
        public byte[]? CurrentCharges { get; set; }
        public long? TotalDueAmt { get; set; }
        public string? AccNo { get; set; }
        public byte[]? BillingDate { get; set; }
        public byte[]? DueDate { get; set; }
        public byte[]? WireLessCharge { get; set; }
        public byte[]? Tvcharge { get; set; }
        public byte[]? VoiceCharge { get; set; }
    }
}
