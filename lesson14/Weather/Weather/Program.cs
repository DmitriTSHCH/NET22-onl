using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Weather
{
    internal class Program
    {
        static HttpClient client = new HttpClient();
        private static async Task Main(string[] args)
        {
            string urlWheatherMinsk = "http://api.weatherapi.com/v1/current.json?key=91665c03d112454684a75108260401&q=Minsk&aqi=no"; // URL для получения текущей погоды в Минске в JSON
            try 
            {
                string responsBody = await client.GetStringAsync(urlWheatherMinsk); // получили данные в формате JSON

                WeatherCurrent weatherCurrent = JsonSerializer.Deserialize<WeatherCurrent>(responsBody); // десериализовали из JSON в объект класса weatherCurrent

                Console.WriteLine($"\nCurrent Weather on {weatherCurrent.location.name}:\nTemperature: {weatherCurrent.current.temp_c} C, feels like {weatherCurrent.current.feelslike_c} C\nWind: {weatherCurrent.current.wind_kph} kph whit gusts {weatherCurrent.current.gust_kph} kph, wind direction: {weatherCurrent.current.wind_dir}\nWindchill temperature: {weatherCurrent.current.windchill_c} C\nHumidity: {weatherCurrent.current.humidity}\nUV index: {weatherCurrent.current.uv}");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"\nException\nMessage: {e.Message}");
            }
        }
    }
}