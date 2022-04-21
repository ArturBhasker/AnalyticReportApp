using ArturBhasker.AnalitycReportBeeLine.Converters;
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
        private readonly IApiConverter _apiConverter;

        public GetCarsController(
            ILogger<GetCarsController> logger,
            IC1NWindRepository repository,
            IApiConverter apiConverter)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _apiConverter = apiConverter ?? throw new ArgumentNullException(nameof(apiConverter));
        }

        /// <summary>
        /// ѕолучить машины по параметру бренда
        /// </summary>
        [Microsoft.AspNetCore.Mvc.HttpGet(Name = "GetCars")]
        public async Task<IActionResult> GetCarsAsync(
            [FromQuery] string brand,
            CancellationToken cancellationToken)
        {
            var command = _apiConverter
                .GetCarsCommand(
                    brand: brand,
                    repository: _repository
                    );

            var razorModel = await command.ExecuteAsync(cancellationToken);


            return View(razorModel);
        }
    }
}