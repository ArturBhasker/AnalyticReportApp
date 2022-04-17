namespace AnalyticReportApp.RazorModels
{
    public class GetCarsRazorModel
    {
        public IEnumerable<CarRazorModel> CarRazorModels { get; }

        public CarHeaderRazorModel CarHeaderRazorModel { get; }

        public string Brand { get; }

        public GetCarsRazorModel(
            IEnumerable<CarRazorModel> carRazorModels,
            CarHeaderRazorModel carHeaderRazorModel,
            string brand)
        {
            CarRazorModels = carRazorModels;
            CarHeaderRazorModel = carHeaderRazorModel;
            Brand = brand;
        }
    }
}
