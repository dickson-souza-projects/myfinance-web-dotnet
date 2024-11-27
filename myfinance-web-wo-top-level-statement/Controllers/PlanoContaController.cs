using Microsoft.AspNetCore.Mvc;

namespace myfinance.web.Controllers;

public class PlanoContaController : Controller
{
    public PlanoContaController()
    {
    }

    public IActionResult Index()
    {
        var resultView = View();
        return resultView;
    }
}
