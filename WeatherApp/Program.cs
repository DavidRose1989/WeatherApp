using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text.Json.Nodes;

namespace WeatherApp 
{
    class Program
    {

        static void Main(string[] args)
        {
            var client = new HttpClient();

            var apiKey = "720ca1003cf1ae2521bdf0a398d29dd7";

            Console.WriteLine("Enter in a city: ");
            var cityName = Console.ReadLine();

            var weatherMapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
            string weatherResponse = client.GetStringAsync(weatherMapURL).Result;
            JObject weatherObject = JObject.Parse(weatherResponse);

            Console.WriteLine("Weather Object");
            Console.WriteLine("Weather: ");
            Console.WriteLine($"It is {weatherObject["main"]["temp"]} degrees Fahrenheit in {cityName}");


        }
    }
}



