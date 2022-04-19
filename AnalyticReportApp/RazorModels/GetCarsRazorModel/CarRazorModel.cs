namespace ArturBhasker.AnalitycReportBeeLine.RazorModels.GetCarsRazorModel
{
    /// <summary>
    /// Модель razor для записи о машине
    /// </summary>
    public class CarRazorModel
    {
        /// <summary>
        /// Бренд
        /// </summary>
        public string Brand { get; }

        /// <summary>
        /// Модель
        /// </summary>
        public string Model { get; }

        /// <summary>
        /// Изображение
        /// </summary>
        public string Image { get; }

        public CarRazorModel(
            string brand,
            string model,
            string image)
        {
            Brand = brand;
            Model = model;
            Image = image;
        }
    }
}