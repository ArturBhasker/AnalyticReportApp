using ArturBhasker.AnalitycReportBeeLine.Extensions;

// ��������� Web ����������
var builder = WebApplication.CreateBuilder();
builder.AddWebApplicationInfrastructure();

var app = builder.Build();
app.AddWebApplicationSettings();

app.Run();