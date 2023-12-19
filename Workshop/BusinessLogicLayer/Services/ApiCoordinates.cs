﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ApiCoordinate
    {
        public static bool CheckCoordinates(decimal x, decimal y)
        {
            HttpClient client = new HttpClient();

            string url = $"https://polygon.gsk567.com/?x={x}&y={y}";

            client.BaseAddress = new Uri(url);

            var response = client.GetAsync(url).Result;

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"{0} ({1})", response.StatusCode, response.ReasonPhrase);
                return false;
            }

            var jsonResponse = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(jsonResponse.ToString());
            JObject parsedJson = JObject.Parse(jsonResponse);

            return parsedJson["in"].Value<bool>();
        }
    }
}