using System.Diagnostics;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using myfinance.web.Infrastructure;
using myfinance.web.Models;

namespace myfinance.web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> logger;
    private MyFinanceDbContext myFinanceDbContext;

    public HomeController(
        ILogger<HomeController> logger,
        MyFinanceDbContext myFinanceDbContext
    )
    {
        this.logger = logger;
        this.myFinanceDbContext = myFinanceDbContext;
    }

    public IActionResult Index()
    {
        var resultView = View();
        return resultView;
    }

    public IActionResult Privacy()
    {
        var resultView = View();
        return resultView;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        var resultView = View(
            new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            }
        );

        return resultView;
    }
}
