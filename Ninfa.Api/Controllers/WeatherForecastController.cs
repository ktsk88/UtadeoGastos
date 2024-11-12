using Microsoft.AspNetCore.Mvc;

using Ninfa.Interface;

namespace Ninfa.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IGptCommunication gpt;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IGptCommunication gpt)
        {
            _logger = logger;
            this.gpt = gpt;
        }

        [HttpGet("{mensaje}")]
        public async Task<ActionResult> GetTest([FromRoute] string mensaje)
        {
            var tender = await gpt.GetBotResponse(mensaje);
            return Ok();
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
