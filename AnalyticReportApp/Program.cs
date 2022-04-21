using ArturBhasker.AnalitycReportBeeLine.Extensions;

// Запускаем Web приложение
var builder = WebApplication.CreateBuilder();
builder.AddWebApplicationInfrastructure();

var app = builder.Build();
app.AddWebApplicationSettings();

app.Run();