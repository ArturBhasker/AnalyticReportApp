namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class Appointment
    {
        public string Id { get; set; } = null!;
        public string Body { get; set; } = null!;
        public byte[] End { get; set; } = null!;
        public string? Location { get; set; }
        public byte[]? Start { get; set; }
        public string? Subject { get; set; }
        public string? Properties { get; set; }
    }
}
