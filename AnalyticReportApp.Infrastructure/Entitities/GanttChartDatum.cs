namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class GanttChartDatum
    {
        public long Id { get; set; }
        public string? Description { get; set; }
        public byte[]? StartDate { get; set; }
        public byte[]? EndDate { get; set; }
        public long? Duration { get; set; }
    }
}
