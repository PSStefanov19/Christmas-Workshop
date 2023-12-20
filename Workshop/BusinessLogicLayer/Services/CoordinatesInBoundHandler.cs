using DataAccessLayer.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ApiCoordinateHandler : IBallHandler
    {
        public static void CheckCoordinates(decimal x, decimal y)
        {
            HttpClient client = new HttpClient();

            string url = $"https://polygon.gsk567.com/?x={x}&y={y}";

            client.BaseAddress = new Uri(url);

            var response = client.GetAsync(url).Result;

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"{0} ({1})", response.StatusCode, response.ReasonPhrase);
                throw new Exception();
            }

            var jsonResponse = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(jsonResponse.ToString());
            JObject parsedJson = JObject.Parse(jsonResponse);

            if (parsedJson["in"].Value<bool>() == false)
            {
                throw new Exception("Ball creation failed");
            }

            
        }
        public void Execute(ChristmasBall ball)
        {
            CheckCoordinates(ball.X, ball.Y);
        }
    }
}