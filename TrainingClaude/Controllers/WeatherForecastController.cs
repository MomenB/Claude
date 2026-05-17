using Microsoft.AspNetCore.Mvc;

namespace TrainingClaude.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        [HttpGet("hello", Name = "Hello")]\

        public string Hello() => "Hello, World111!";

        [HttpGet("hello2", Name = "Hello2")]
        public string Hello2() => "Hello 2, World!";

        [HttpGet("quickstart", Name = "Quickstart")]
        public string Quickstart() => "Quickstart!";

        [HttpGet("hello5", Name = "Hello5")]
        public string Hello5() => "Hello, World 5!";

        [HttpGet("helloPVMS", Name = "HelloPVMS")]
        public string HelloPVMS() => "Hello, PVMS!";

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
