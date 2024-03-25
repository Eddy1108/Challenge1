using Challenge1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Challenge1.ViewModels;

namespace Challenge1.Controllers;

public class HomeController(/*ILogger<HomeController> logger*/ CustomerService customerService)
    : Controller
{
    //private readonly ILogger<HomeController> _logger = logger;

    public async Task<ViewResult> Index()
    {
        //get the customers from the service
        var customers = await customerService.GetCustomers();

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