namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class Category
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public string? Picture { get; set; }
    }
}
