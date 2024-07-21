using Microsoft.AspNetCore.Mvc;

using CompanyName.ProjectName.ServiceName.Contracts;
using CompanyName.ProjectName.ServiceName.MessageTransfert;
using CompanyName.ProjectName.ServiceName.Dto;
using CompanyName.ProjectName.Services;

namespace CompanyName.ProjectName.ServiceName.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class YourServiceController : ControllerBase ,IServiceContract
    {
        [HttpPost("GetMessage")]
        public MessageResponse<YourDto> GetMessage(MessageRequest<YourDto> messageRequest)
        {
            Your_Service yourService = new Your_Service();
            return yourService.GetMessage(messageRequest);
        }


        [HttpGet("GetMessage")]
        public string GetMessage()
        {
            Your_Service yourService = new Your_Service();
            return yourService.GetMessage();
        }


        [HttpGet("TestContextRepository")]
        public void TestContextRepository()
        {
            Your_Service yourService = new Your_Service();
        }

        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
