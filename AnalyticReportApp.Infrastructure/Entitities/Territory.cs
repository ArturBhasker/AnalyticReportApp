namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class Territory
    {
        public string TerritoryId { get; set; } = null!;
        public string TerritoryDescription { get; set; } = null!;
        public long RegionId { get; set; }
    }
}
