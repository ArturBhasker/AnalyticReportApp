using System.Linq;
using System.Threading;
using ArturBhasker.AnalitycReportBeeLine.Controllers;
using ArturBhasker.Infrastructure.UnitTests.Entitities;
using ArturBhasker.Infrastructure.UnitTests.Repositories;
using AutoFixture;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace ArturBhasker.AnalitycReportBeeLine.UnitTests
{
    public class GetCarsControllerTests
    {
        [Fact]
        public async System.Threading.Tasks.Task GetCarsControllerAsync_Success()
        {
            // Arrange
            var fixture = new Fixture();

            var repositoryMock = new Mock<IC1NWindRepository>();
            var loggerMock = new Mock<ILogger<GetCarsController>>();
            repositoryMock
                .Setup(r => r.GetCarsAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(fixture.CreateMany<Car>().ToList());

            var controller = new GetCarsController(
                logger: loggerMock.Object,
                repository: repositoryMock.Object);

            //Act
            var cars = await controller.GetCarsAsync(
                fixture.Create<string>(),
                CancellationToken.None);

            //Assert
            Assert.NotNull(cars);

            repositoryMock
                .Verify(item => item.GetCarsAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()));

        }
    }
}