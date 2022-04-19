namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class Shipper
    {
        public long ShipperId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Phone { get; set; }
    }
}
