using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

            if (!result.IsSuccessStatusCode) await HandleServerErrorResponsesAsync(result);

            return await FromHttpResponseMessage<T>(result);
        }

        public static async Task<T> PostAsync<T>(string uri, object requestDataToSend)
        where T : class
        {
            using var _httpClient = new HttpClient();

            var content = ToJson(requestDataToSend);

            var result = await _httpClient.PostAsync($"{_apiUrl}/{uri}", content);

            if (!result.IsSuccessStatusCode) await HandleServerErrorResponsesAsync(result);

            return await FromHttpResponseMessage<T>(result);
        }

        public static async Task<T> PutAsync<T>(string uri, object requestDataToSend)
        where T : class
        {
            using var _httpClient = new HttpClient();

            var content = ToJson(requestDataToSend);

            var result = await _httpClient.PutAsync($"{_apiUrl}/{uri}", content);

            if (!result.IsSuccessStatusCode) await HandleServerErrorResponsesAsync(result);

            return await FromHttpResponseMessage<T>(result);
        }

        public static async Task<T> DeleteAsync<T>(string uri, Guid id)
        where T : class
        {
            using var _httpClient = new HttpClient();

            var result = await _httpClient.DeleteAsync($"{_apiUrl}/{uri}/{id}");

            if (!result.IsSuccessStatusCode) await HandleServerErrorResponsesAsync(result);

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

        private static StringContent ToJson(object obj)
        {
            return new StringContent(JsonSerializer.Serialize(obj), Encoding.UTF8, "application/json");
        }

        private static async Task HandleServerErrorResponsesAsync (HttpResponseMessage responseMessage)
        {
            var serverErrorResponse = JsonSerializer.Deserialize<ServerErrorResponse>(await responseMessage.Content.ReadAsStringAsync(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

            switch (responseMessage.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                    throw new Exception($"Server Error: {serverErrorResponse?.Message}");
                case HttpStatusCode.InternalServerError:
                    throw new Exception("Server Error: Error interno del server. Vuelva a intentarlo.");
            }
        }
    }

    public class ServerErrorResponse
    {
        public string Message { get; set; }
    }
}
