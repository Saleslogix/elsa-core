using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Elsa.Http.Services;

namespace Elsa.Http.Parsers.Response;

public class JsonElementHttpResponseContentReader : IHttpResponseContentReader
{
    public string Name => "JToken";
    public int Priority => 0;
    public bool GetSupportsContentType(string contentType) => contentType.Contains("/json", StringComparison.OrdinalIgnoreCase);
    public async Task<object> ReadAsync(HttpResponseMessage response, object context, CancellationToken cancellationToken)
    {
        var json = (await response.Content.ReadAsStringAsync()).Trim();
        return JsonDocument.Parse(json).RootElement;
    }
}