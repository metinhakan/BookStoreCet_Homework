using System.Diagnostics;
using BookStoreCet.Data;
using Microsoft.AspNetCore.Mvc;
using BookStoreCet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreCet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        using (var db = new MyDbContext())
        {
            var cheapestbooks = db.Books.OrderBy(p => p.Price).Take(3).ToList();
            return View(cheapestbooks);
        }
        {
            
        }
       
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