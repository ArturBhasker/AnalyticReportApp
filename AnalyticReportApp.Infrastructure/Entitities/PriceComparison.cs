namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class PriceComparison
    {
        public long ProductId { get; set; }
        public string? ProductType { get; set; }
        public string? ProductName { get; set; }
        public long? Price2013 { get; set; }
        public long? Price2014 { get; set; }
        public byte[]? ProductTypePhoto { get; set; }
    }
}
