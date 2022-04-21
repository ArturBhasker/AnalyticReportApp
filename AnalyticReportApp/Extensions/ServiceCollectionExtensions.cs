using ArturBhasker.AnalitycReportBeeLine.Converters;
using ArturBhasker.Infrastructure.UnitTests.Extensions;

namespace ArturBhasker.AnalitycReportBeeLine.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddWebApplicationInfrastructure(this WebApplicationBuilder builder)
        {
            var builderConfiguration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configuration = builderConfiguration.Build();

            var connectionString = configuration["ConnectionString"] ?? throw new ArgumentNullException("connectionString");

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddMvc();

            builder.Services.AddScoped<IApiConverter, ApiConverter>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContexts(connectionString);
            builder.Services.AddRepositories();
        }

        public static void AddWebApplicationSettings(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
