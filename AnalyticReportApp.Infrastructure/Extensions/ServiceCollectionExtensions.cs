using AnalyticReportApp.Infrastructure.DbContexts;
using AnalyticReportApp.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace AnalyticReportApp.Infrastructure.Extensions
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
