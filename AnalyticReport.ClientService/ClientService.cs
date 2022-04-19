using Microsoft.AspNetCore.WebUtilities;
using Polly;

namespace ArturBhasker.AnalitycReportBeeLine.ClientService;

public class ClientService
{
    private const string BrandParameter = "Brand";
    private const string UriPath = "GetCars";

    private readonly string _baseUrl;

    public ClientService(
        string baseUrl,
        string[] consoleArgs)
    {
        _baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
    }

    public async Task<string> GetCarsFromServer(string brand)
    {
        var baseUri = new Uri(_baseUrl);

        var uri = new Uri(baseUri, UriPath);

        var uriWithQuery = QueryHelpers.AddQueryString(uri.ToString(), BrandParameter, brand);

        using var httpClient = new HttpClient();

        var httpRequest = new HttpRequestMessage(
            method: HttpMethod.Get,
            requestUri: uriWithQuery
        );

        var httpResponse = await SendRequestRetryPolicyAsync(httpRequest);

        var htmlString = await httpResponse.Content.ReadAsStringAsync();

        return htmlString;
    }

    private async Task<HttpResponseMessage> SendRequestRetryPolicyAsync(HttpRequestMessage request)
    {
        var polly = Policy
            .Handle<HttpRequestException>()
            .OrResult<HttpResponseMessage>(response => !response.IsSuccessStatusCode)
            .WaitAndRetryAsync(5, _ => TimeSpan.FromSeconds(1));

        var httpResponseMessage = await polly
            .ExecuteAsync(async () =>
            {
                using var httpClient = new HttpClient();

                var httpResponse = await httpClient
                    .SendAsync(request);

                return httpResponse;
            });

        return httpResponseMessage;
    }
}