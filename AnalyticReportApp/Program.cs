using ArturBhasker.AnalitycReportBeeLine.ClientService;
using ArturBhasker.AnalitycReportBeeLine.Extensions;
using Mono.Options;
using Polly;

// ��������� Web ����������
var builder = WebApplication.CreateBuilder();
builder.AddWebApplicationInfrastructure();

var app = builder.Build();
app.AddWebApplicationSettings();

Task.Run(() => app.RunAsync());

//������ ������� ��������� ����������

//�������� �������� ���������� �� ���������
string brand = "BMW";
string outputHtml = "MyHtml.html";

var p = new OptionSet() {
    { "m|mark=", "the name of car brand.",
        v => brand = v },
    { "o|outputFile=",
        "output html name",
        v => outputHtml = v },
};

p.Parse(args);

//�������� �������� uri ��� �������
var polly = Policy
    .Handle<InvalidOperationException>()
    .WaitAndRetry(5, _ => TimeSpan.FromSeconds(1));

var baseUrl = polly
    .Execute(() => app.Urls.First());

//������ ������ �������
var clientService = new ClientService(
    baseUrl,
    args);

//��������� �������� html
var html = await clientService.GetCarsFromServer(brand);

//���������� ��� � ����
File.WriteAllText(outputHtml, html);