using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using MobileApi3.Model;

namespace MobileApi3.Service
{
    public class RestService
    {
        HttpClient httpClient;
        JsonSerializerOptions serializerOptions;
        public List<Rootobject> WeatherItem { get; set; }
        public RestService()
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback =
                (message, cert, chain, errors) => { return true; };
            client = new HttpClient(httpClientHandler);

            serializerOptions = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };
        }
        public async Task<List<Rootobject>> GetWeatherItemAsync()
        {
            WeatherItem = new List<Rootobject>();
            Uri uri = new Uri(string.Format(Constants))
        }
    }
}
