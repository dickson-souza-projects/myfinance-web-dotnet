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
        if (model != null && ModelState.IsValid && this.Request.Method == "POST")
        {
            var newItemId = planoContaService.Salvar(model);

            var planoContaModel = planoContaService.RetornarRegistro(newItemId);
            return View(planoContaModel);
        }
        else
        {
        var resultView = View();
        return resultView;
        }

    }

    [HttpGet]
    [HttpPost]
    [Route("Cadastro/{id}")]
    public IActionResult Cadastro(int id, PlanoContaModel? model)
    {
        if (model != null && ModelState.IsValid && this.Request.Method == "POST")
    {
            var savedId = planoContaService.Salvar(model);

            var savedPlanoContaModel = planoContaService.RetornarRegistro(savedId);
            return View(savedPlanoContaModel);
        }

        var planoContaModel = planoContaService.RetornarRegistro(id);

        return View(planoContaModel);
    }

}
