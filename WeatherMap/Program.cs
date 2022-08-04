using Newtonsoft.Json.Linq;
using System.Net.Http;
using System;





var client = new HttpClient();

var key = "d4f4066e7577dc0f941e6b2b5ce02d8b";


while (true)
{
    Console.WriteLine("Enter the city name");
    var cityName = Console.ReadLine();
    Console.WriteLine();

    var weatherURL = $"https://api.openweathermap.org/data/2.5/forecast?q={cityName}&appid={key}&units=imperial";
    var response = client.GetStringAsync(weatherURL).Result;
    JObject jsonObject = JObject.Parse(response);
    var temp = jsonObject["list"][0]["main"]["temp"];


    Console.WriteLine($"The Current Temperature is {temp}degrees Fahrenheit");
    Console.WriteLine("would you like to exit?");
    var userInput = Console.ReadLine();

    if (userInput.ToLower().Trim() == "yes")
    {
        break;
    }

}