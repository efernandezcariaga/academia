using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Desktop.Helpers
{
    public static class HttpClientHelper
    {
        private static readonly string _apiUrl = "https://localhost:7066/api";

        public static async Task<T> GetAsync<T>(string uri)
        where T : class
        {
            using var _httpClient = new HttpClient();

            var result = await _httpClient.GetAsync($"{_apiUrl}/{uri}");

            if (!result.IsSuccessStatusCode)
            {
                return null;
            }

            return await FromHttpResponseMessage<T>(result);
        }

        private static async Task<T> FromHttpResponseMessage<T>(HttpResponseMessage result)
        {
            #pragma warning disable CS8603 // Possible null reference return.
            return JsonSerializer.Deserialize<T>(await result.Content.ReadAsStringAsync(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });
            #pragma warning restore CS8603 // Possible null reference return.
        }
    }
}
