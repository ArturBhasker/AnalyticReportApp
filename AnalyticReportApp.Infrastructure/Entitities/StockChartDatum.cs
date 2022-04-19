namespace ArturBhasker.Infrastructure.UnitTests.Entitities
{
    public partial class StockChartDatum
    {
        public long Id { get; set; }
        public string? PriceDate { get; set; }
        public byte[]? High { get; set; }
        public byte[]? Low { get; set; }
        public byte[]? Close { get; set; }
        public byte[]? Volumn { get; set; }
        public byte[]? AdjClose { get; set; }
    }
}
