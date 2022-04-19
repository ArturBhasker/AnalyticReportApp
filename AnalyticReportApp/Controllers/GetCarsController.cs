using ArturBhasker.AnalitycReportBeeLine.RazorModels.GetCarsRazorModel;
using ArturBhasker.Infrastructure.UnitTests.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ArturBhasker.AnalitycReportBeeLine.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class GetCarsController : Controller
    {
        private readonly ILogger<GetCarsController> _logger;
        private readonly IC1NWindRepository _repository;

        public GetCarsController(
            ILogger<GetCarsController> logger,
            IC1NWindRepository repository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// ѕолучить машины по параметру бренда
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpGet(Name = "GetCars")]
        public async Task<IActionResult> GetCarsAsync(
            [FromQuery] string brand,
            CancellationToken cancellationToken)
        {
            var u = this.ControllerContext;

            var brandCars = await _repository.GetCarsAsync(
                brand: brand,
                cancellationToken: cancellationToken
            );

            var fuelAverage = await _repository.GetAverageFuelAsync(cancellationToken);
            var carsCount = await _repository.GetCarsCountAsync(cancellationToken);


            var carRazorModels = brandCars
                .Select(
                    car =>
                    {
                        return new CarRazorModel(
                            brand: car.Brand ?? throw new ArgumentNullException(nameof(car.Brand)),
                            model: car.Model ?? throw new ArgumentNullException(nameof(car.Model)),
                            image: car.Picture ?? throw new ArgumentNullException(nameof(car.Picture))
                        );
                    });

            var fuelAverageBrand = brandCars
                .Average(brandCar => brandCar.Liter);

            var carsCountBrand = brandCars
                .Count();

            var carHeaderRazorModel = new CarHeaderRazorModel(
                brandCarsCount: carsCountBrand,
                brandFuelAverage: fuelAverageBrand,
                fuelAverage: fuelAverage,
                carsCount: carsCount
            );

            var razorModel = new GetCarsRazorModel(
                carRazorModels: carRazorModels,
                carHeaderRazorModel: carHeaderRazorModel,
                brand: brand);


            return View(razorModel);
        }
    }
}