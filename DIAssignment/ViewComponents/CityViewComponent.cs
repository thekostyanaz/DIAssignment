using Microsoft.AspNetCore.Mvc;
using Models;

namespace DIAssignment.ViewComponents
{
	public class CityViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(CityWeather weatherInCity) 
		{
			return View(weatherInCity);
		}
	}
}
