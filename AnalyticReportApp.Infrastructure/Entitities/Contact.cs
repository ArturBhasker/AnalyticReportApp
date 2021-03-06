namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class Contact
    {
        public string? UserCode { get; set; }
        public byte[]? ContactDate { get; set; }
        public byte[] Callback { get; set; } = null!;
        public string? Comments { get; set; }
        public long? ContactType { get; set; }
    }
}
