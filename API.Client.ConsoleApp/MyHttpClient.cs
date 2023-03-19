using API.Shared.Helper;
using API.Shared.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace API.Client.ConsoleApp
{
    class MyHttpClient
    {
        static string apiUrl = "https://localhost:44363/api/";
        static void Main(string[] args)
        {
            var r = GetAsync();
        }

        public static async Task<string> GetAsync()
        {
            string result = "";
            try
            {
                using HttpClient client = new HttpClientHelper(apiUrl).GetHttpClient();
                var response = client.GetAsync("Employee").Result;
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsStringAsync();
                }
            }
            catch(Exception e)
            {
                throw;
            }
            return result;
        }
    }
}
