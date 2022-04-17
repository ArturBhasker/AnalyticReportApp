namespace AnalyticReportApp.Infrastructure.DbContexts
{
    public interface IUnitOfWork
    {
        public System.Threading.Tasks.Task SaveEntitiesAsync(CancellationToken cancellationToken);
    }
}
