using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace DIAssignment.Controllers
{
	public class WeatherController : Controller
	{
		private readonly IWeatherService _weatherService;

		public WeatherController(IWeatherService weatherService) 
		{
			_weatherService = weatherService;
		}

		[Route("/")]
		public IActionResult Weather()
		{
			var weatherData = _weatherService.GetWeatherDetails();
			return View(weatherData);
		}

		[Route("/weather/{cityCode}")]
		public IActionResult City(string cityCode)
		{
			var city = _weatherService.GetWeatherByCityCode(cityCode);
			if (city != default)
			{
				return View(city);
			}
			return View("Error", cityCode);
		}
	}
}
