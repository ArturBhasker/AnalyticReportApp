using ArturBhasker.AnalitycReportBeeLine.Commands;
using ArturBhasker.AnalitycReportBeeLine.RazorModels.GetCarsRazorModel;
using ArturBhasker.Infrastructure.UnitTests.Repositories;

namespace ArturBhasker.AnalitycReportBeeLine.Converters
{
    public interface IApiConverter
    {
        ICommand<GetCarsRazorModel> GetCarsCommand(
            string brand,
            IC1NWindRepository repository);
    }
}