using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanS
{
    public static class MeteoClient
    {
        private const string address = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&hourly=temperature_2m,relativehumidity_2m,windspeed_10m";

        public static async Task<string> GetMeteo()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(address)
            };
            var data = await client.GetAsync(address);

            data.EnsureSuccessStatusCode();

            return await data.Content.ReadAsStringAsync();
        }
    }
}
