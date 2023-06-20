using Models;
using ServiceContracts;

namespace Services
{
	public class WeatherService : IWeatherService
	{
		private List<CityWeather> _cityWeathers;

		public WeatherService() 
		{
			_cityWeathers = new List<CityWeather>
			{
				new CityWeather() { CityUniqueCode = "LDN", CityName = "London", DateAndTime = Convert.ToDateTime("2030-01-01 8:00:00 AM"),  TemperatureFahrenheit = 33 },
				new CityWeather() { CityUniqueCode = "NYC", CityName = "New York City", DateAndTime = Convert.ToDateTime("2030-01-01 3:00:00 AM"),  TemperatureFahrenheit = 60 },
				new CityWeather() { CityUniqueCode = "PAR", CityName = "Paris", DateAndTime = Convert.ToDateTime("2030-01-01 9:00:00 AM"),  TemperatureFahrenheit = 82 }
			};
		}

		public CityWeather? GetWeatherByCityCode(string cityCode)
		{
			return _cityWeathers.FirstOrDefault(w => w.CityUniqueCode == cityCode);
		}

		public List<CityWeather> GetWeatherDetails()
		{
			return _cityWeathers;
		}
	}
}