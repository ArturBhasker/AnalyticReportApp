namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class AppointmentsFull
    {
        public string AppointmentId { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] End { get; set; } = null!;
        public string? Location { get; set; }
        public byte[]? Start { get; set; }
        public string? Subject { get; set; }
        public string? Properties { get; set; }
    }
}
