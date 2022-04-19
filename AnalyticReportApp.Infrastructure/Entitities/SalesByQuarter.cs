namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class SalesByQuarter
    {
        public long Id { get; set; }
        public string? QuarterMonth { get; set; }
        public byte[]? ProductX { get; set; }
        public byte[]? ProductY { get; set; }
        public byte[]? ProductZ { get; set; }
    }
}
