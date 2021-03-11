//pulled using statement from basic template of weatherForecastController
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LectureWithAngel.service
{
    //best practice is to use camelCase
    public class WeatherForecastService
    {
        public IEnumerable<WeatherForecast> getRandomWeather(string[] Summaries)
        {
            var rng = new Random();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)] + "Joseph"
                //how de get access to our summaries?
                // /make changes to our controller, we know that my Summaries were being taken as a string array so in this case WeakReference need to pass int hat same string array so we can ahve access to our summaries
                //no we have to do that on the controller side
            })
            .ToArray();

        }
    }
}