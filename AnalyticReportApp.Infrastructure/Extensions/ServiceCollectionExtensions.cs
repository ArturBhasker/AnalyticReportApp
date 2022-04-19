using ArturBhasker.Infrastructure.UnitTests.DbContexts;
using ArturBhasker.Infrastructure.UnitTests.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ArturBhasker.Infrastructure.UnitTests.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDbContexts(this IServiceCollection services,
            string connectionString)
        {
            services.AddDbContext<C1NWindContext>(
                options =>
                {
                    options.UseSqlite(connectionString);
                }
                );
            services.AddScoped<IUnitOfWork>(d => d.GetRequiredService<C1NWindContext>());
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IC1NWindRepository,C1NWindRepository>();
        }
    }
}
