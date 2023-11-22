using Microsoft.AspNetCore.Mvc;

namespace Challenge1.Controllers;

public class ProductsController : Controller
{
    public ProductsController()
    {
    }

    // GET
	public async Task<ViewResult> Index()
    {
        return View();
    }
}