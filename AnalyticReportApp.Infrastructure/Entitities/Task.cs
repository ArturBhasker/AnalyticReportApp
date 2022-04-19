namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class Task
    {
        public long Id { get; set; }
        public long? TaskId { get; set; }
        public string? Name { get; set; }
        public byte[]? Start { get; set; }
        public byte[]? Finish { get; set; }
        public long? Duration { get; set; }
        public long? OutlineParentId { get; set; }
        public byte[]? Summary { get; set; }
        public long? NextId { get; set; }
        public long? Mode { get; set; }
        public long? CalendarId { get; set; }
        public long? DurationUnits { get; set; }
        public long? PercentComplete { get; set; }
        public byte[]? Deadline { get; set; }
        public long? ConstraintType { get; set; }
        public byte[]? ConstraintDate { get; set; }
        public byte[]? HideBar { get; set; }
        public byte[]? Initialized { get; set; }
        public string? Predecessors { get; set; }
        public string? Resources { get; set; }
        public string? Notes { get; set; }
        public string? CustomFields { get; set; }
        public string? Parts { get; set; }
    }
}
