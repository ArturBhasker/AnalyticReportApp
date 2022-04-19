using ArturBhasker.Infrastructure.UnitTests.Entitities;

namespace ArturBhasker.Infrastructure.UnitTests.Repositories
{
    public interface IC1NWindRepository
    {
        /// <summary>
        /// Получить список машин
        /// </summary>
        public Task<IList<Car>> GetCarsAsync(
            string brand,
            CancellationToken cancellationToken);

        /// <summary>
        /// Получить количество машин
        /// </summary>
        public Task<int> GetCarsCountAsync(
    CancellationToken cancellationToken);

        /// <summary>
        /// Получить средний объем толкива
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<double> GetAverageFuelAsync(
CancellationToken cancellationToken);
    }
}
