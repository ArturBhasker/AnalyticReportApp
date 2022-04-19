namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class TaskList
    {
        public string Task { get; set; } = null!;
        public string? Department { get; set; }
        public string? Client { get; set; }
        public string? Person { get; set; }
        public string? TaskGroup { get; set; }
        public byte[]? Target { get; set; }
        public byte[]? StartDate { get; set; }
        public byte[]? EntryDate { get; set; }
        public long? Duration { get; set; }
        public byte[] Done { get; set; } = null!;
    }
}
