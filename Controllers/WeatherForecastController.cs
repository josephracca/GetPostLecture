using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectureWithAngel.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LectureWithAngel.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //still not sure the naming, but wants to call it ROUTE DICTATION, by default uses the controller name...which here is NAME OF FILE MINUS the CONTROLLER PART
    //route would be /WeatherForecast, similar to Auth/login, name of controller was AuthController, so we used "Auth" plus another specific endpoint / "login"
    // "Auth/login"

    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            //string array readonly, non-writable
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public readonly WeatherForecastService _data;
        //cmmd+period

        //CONSTRUCTOR, public
        //name
        //parameters for constructor, etc
        //gets data from our service
        //constructor is how we did it in c#
        //using the controller to read and write...
        //controller will handle the majority of our CRUD functions

        //how to know it's a constructor, usually is the same name as the class
        public WeatherForecastController(ILogger<WeatherForecastController> logger, WeatherForecastService data)
        {
            _logger = logger;
            // /make connections 
            _data = data;
            // allows us to have functionality in our service
        }

        [HttpGet]
        //create service folder and file, connect controller tot he service and hav the data go from the controller, read the model to make sure it's right, get data that we need, and then send it right back to controller and send response to our postman

        //^^ specifies the type of http method that we are going to use GET in this case 
        //[HttpDelete]
        //[HttpPost]

        //function syntax: we can return data or not
        //all start with public,
        //data type that we are going to return

        //examples:
        // public string Get(){}
        // public int Get() { }
        // public bool Get() { }
        // public WeatherForecast Get() { } <----specific data type
        public IEnumerable<WeatherForecast> Get()
        //return enumrable range,
        //each I object is going to be a weatherForecast type
        {

            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast

            //creating a new weatherForecast model, click into CS to see what it is...pretty much what OUR models are going to look like 
            //whenever we return the get, we return a collection of 5 items with all of these fields
            //REFER TO WeatherForecast.cs
            // {
            //     // Date = DateTime.Now.AddDays(index),
            //     //sets date
            //     // TemperatureC = rng.Next(-20, 55),
            //     //sets random temp
            //     // Summary = Summaries[rng.Next(Summaries.Length)] + "Joseph"
            //     //sets random summarypo

            //     //models will most likely be constructed with classes
            //     //only difference between Angels DBs, his has the auto-id, continuous generator, auto generated IDs

            //     //before postman: Startup.cs JUMP IN
            // })
            // .ToArray();

            return _data.getRandomWeather(Summaries);
            // AttributeTargets speciofic function

            //we'll need to do one more step on this...
        }
    }
}


//tomorrow will be POST
//POSTS will be case sensitive
//creates a DLL file, like in the dist folder for React or Angular, places it in the bin file and runs it from there... changes to code won't reflect if already

//to end it off... making a new service folder

//NEW LECTURE:
// missed the whole first sec
//client side: postman