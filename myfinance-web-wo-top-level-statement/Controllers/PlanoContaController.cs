using Microsoft.AspNetCore.Mvc;

using myfinance.web.Models;
using myfinance.web.Services;

namespace myfinance.web.Controllers;

[Route("[controller]")]
public class PlanoContaController : Controller
{
    private readonly IPlanoContaService planoContaService;

    public PlanoContaController(IPlanoContaService planoContaService)
    {
        this.planoContaService = planoContaService;
    }

    [Route("Index")]
    public IActionResult Index()
    {
        var resultView = View();
        ViewBag.List = planoContaService.ListarRegistros();
        return resultView;
    }

    [HttpGet]
    [HttpPost]
    [Route("Cadastro")]
    public IActionResult Cadastro(PlanoContaModel? model)
    {
        if (model != null && ModelState.IsValid && this.Request.Method == "POST")
        {
            _ = planoContaService.Salvar(model);
            return RedirectToAction("Index");
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

    [HttpGet]
    [Route("Excluir/{id}")]
    public IActionResult Excluir(int id)
    {
        try
        {
            planoContaService.Excluir(id);
        }
        catch
        {
            // Do nothing
        }
        return RedirectToAction("Index");
    }
}
