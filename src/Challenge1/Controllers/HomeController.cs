using System.Collections;
using Challenge1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Challenge1.Data;
using Challenge1.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Challenge1.Controllers
{
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly TheAppContext _theAppContext;

		public HomeController(ILogger<HomeController> logger, TheAppContext appContext)
		{
			_logger = logger;
			_theAppContext = appContext;
		}

		public async Task<ViewResult> Index()
		{
			//get the customers from the database
			var customers = await _theAppContext.Customers.ToListAsync();

			var homeModel = new HomeModel()
			{
				//pass the customers to the model
				Customers = customers

			};
			return View(homeModel);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
