using ArturBhasker.AnalitycReportBeeLine.Commands;
using ArturBhasker.AnalitycReportBeeLine.RazorModels.GetCarsRazorModel;
using ArturBhasker.Infrastructure.UnitTests.Repositories;

namespace ArturBhasker.AnalitycReportBeeLine.Converters
{
    internal class ApiConverter : IApiConverter
    {
        public ICommand<GetCarsRazorModel> GetCarsCommand(
            string brand,
            IC1NWindRepository repository)
        {
            return new GetCarsCommand(
                repository: repository,
                brand: brand
            );
        }
    }
}