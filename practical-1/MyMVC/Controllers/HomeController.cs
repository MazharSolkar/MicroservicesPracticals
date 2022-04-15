using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myMvc.Models;

namespace MyMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new StockQuote{Symbol="HLLO",Price=3200,By="Mazhar Solkar"};
        return View(model);
    }

}
