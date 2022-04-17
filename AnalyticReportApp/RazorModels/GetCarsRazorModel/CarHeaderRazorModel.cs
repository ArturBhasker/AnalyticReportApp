namespace AnalyticReportApp.RazorModels
{
    /// <summary>
    /// Модель заголовка для таблцы с машинами
    /// </summary>
    public class CarHeaderRazorModel
    {
        /// <summary>
        /// Количество машин
        /// </summary>
        public int CarsCount{ get; }

        /// <summary>
        /// Количество машин заданной марки
        /// </summary>
        public int BrandCarsCount { get; }

        /// <summary>
        /// Средний объём топлива
        /// </summary>
        public double FuelAverage { get; }

        /// <summary>
        /// Средний объём топлива заданной марки
        /// </summary>
        public double BrandFuelAverage { get; }

        public CarHeaderRazorModel(
            int carsCount,
            int brandCarsCount,
            double fuelAverage,
            double brandFuelAverage)
        {
            CarsCount = carsCount;
            BrandCarsCount = brandCarsCount;
            FuelAverage = fuelAverage;
            BrandFuelAverage = brandFuelAverage;
        }
    }
}
