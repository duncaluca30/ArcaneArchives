using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Helpers
{
    public class ApiHelper
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("https://yourapi.com/api/") };

        public static async Task<T> GetAsync<T>(string endpoint)
        {
            var response = await client.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public static async Task<HttpResponseMessage> PostAsync<T>(string endpoint, T data)
        {
            return await client.PostAsJsonAsync(endpoint, data);
        }
    }
}
