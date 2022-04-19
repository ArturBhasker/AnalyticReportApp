using ArturBhasker.AnalitycReportBeeLine.ClientService;
using ArturBhasker.AnalitycReportBeeLine.Extensions;
using Mono.Options;
using Polly;

// Запускаем Web приложение
var builder = WebApplication.CreateBuilder();
builder.AddWebApplicationInfrastructure();

var app = builder.Build();
app.AddWebApplicationSettings();

Task.Run(() => app.RunAsync());

//Парсим входные параметры приложения

//Значение выходных параметров по умолчанию
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

//Пытаемся получить uri веб сервера
var polly = Policy
    .Handle<InvalidOperationException>()
    .WaitAndRetry(5, _ => TimeSpan.FromSeconds(1));

var baseUrl = polly
    .Execute(() => app.Urls.First());

//Создаём сервис клиента
var clientService = new ClientService(
    baseUrl,
    args);

//Получаемы итоговый html
var html = await clientService.GetCarsFromServer(brand);

//Записываем его в файл
File.WriteAllText(outputHtml, html);