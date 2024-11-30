using Microsoft.AspNetCore.Mvc;

using myfinance.web.Domain;
using myfinance.web.Models;
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

    [HttpGet]
    [HttpPost]
    public IActionResult Cadastro(PlanoContaModel? model)
    {
        if (model != null && ModelState.IsValid)
        {
            planoContaService.Salvar(model);
        }

        var resultView = View();
        return resultView;
    }
}
