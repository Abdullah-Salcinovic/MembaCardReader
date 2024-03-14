﻿using System.IO.Ports;
using System.Security.Principal;

class Program
{
    public static async Task Main()
    {
        using var httpClient = new HttpClient();

        string baseUrl = "http://192.168.1.203:5174/api";

        string endpoint = "/customer?id=1";

        string requestUrl = baseUrl + endpoint;

        static async Task GetAsync(HttpClient httpClient, string uri)
        {
            using HttpResponseMessage response = await httpClient.GetAsync(uri);


            var jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"{jsonResponse}\n");
        }

        await GetAsync(httpClient, requestUrl);
    }
}
