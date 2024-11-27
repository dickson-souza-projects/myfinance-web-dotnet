using Microsoft.AspNetCore.Mvc;

using myfinance.web.Services;

namespace myfinance.web.Controllers;

public class PlanoContaController : Controller
{
    private readonly IPlanoContaService planoContaService;

    public PlanoContaController(IPlanoContaService planoContaService)
    {
        this.planoContaService = planoContaService;
    }

    public IActionResult Index()
    {
        var resultView = View();
        ViewBag.List = planoContaService.ListarRegistros();
        return resultView;
    }

    public IActionResult Cadastro() 
    {
        var resultView = View();
        return resultView;
    }

}
