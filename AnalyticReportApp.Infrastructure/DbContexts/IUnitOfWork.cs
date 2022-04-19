namespace ArturBhasker.Infrastructure.UnitTests.DbContexts
{
    public interface IUnitOfWork
    {
        public System.Threading.Tasks.Task SaveEntitiesAsync(CancellationToken cancellationToken);
    }
}
