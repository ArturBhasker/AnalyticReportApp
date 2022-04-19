namespace ArturBhasker.Infrastructure.UnitTests.DbContexts
{
    partial class C1NWindContext : IUnitOfWork
    {
        public async System.Threading.Tasks.Task SaveEntitiesAsync(CancellationToken cancellationToken)
        {
            await SaveChangesAsync(cancellationToken);
        }
    }
}
