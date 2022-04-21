using ArturBhasker.AnalitycReportBeeLine.RazorModels.GetCarsRazorModel;
using ArturBhasker.Infrastructure.UnitTests.Repositories;

namespace ArturBhasker.AnalitycReportBeeLine.Commands
{
    internal class GetCarsCommand : ICommand<GetCarsRazorModel>
    {
        private readonly IC1NWindRepository _repository;
        private readonly string _brand;

        public GetCarsCommand(
            IC1NWindRepository repository,
            string brand
        )
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _brand = brand ?? throw new ArgumentNullException(nameof(brand));
        }

        public async Task<GetCarsRazorModel> ExecuteAsync(CancellationToken cancellationToken)
        {
            var brandCars = await _repository.GetCarsAsync(
                brand: _brand,
                cancellationToken: cancellationToken
            );

            var fuelAverage = await _repository.GetAverageFuelAsync(cancellationToken);
            var carsCount = await _repository.GetCarsCountAsync(cancellationToken);


            var carRazorModels = brandCars
                .Select(
                    car => new CarRazorModel(
                        brand: car.Brand ?? throw new ArgumentNullException(nameof(car.Brand)),
                        model: car.Model ?? throw new ArgumentNullException(nameof(car.Model)),
                        image: car.Picture ?? throw new ArgumentNullException(nameof(car.Picture))
                    ));

            var fuelAverageBrand = brandCars
                .Average(brandCar => brandCar.Liter);

            var carsCountBrand = brandCars
                .Count;

            var carHeaderRazorModel = new CarHeaderRazorModel(
                brandCarsCount: carsCountBrand,
                brandFuelAverage: fuelAverageBrand,
                fuelAverage: fuelAverage,
                carsCount: carsCount
            );

            var razorModel = new GetCarsRazorModel(
                carRazorModels: carRazorModels,
                carHeaderRazorModel: carHeaderRazorModel,
                brand: _brand);

            return razorModel;
        }
    }
}
