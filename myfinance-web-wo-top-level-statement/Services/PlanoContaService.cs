using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Extensions.Logging;

using myfinance.web.Controllers;
using myfinance.web.Domain;
using myfinance.web.Infrastructure;

namespace myfinance.web.Services;

public class PlanoContaService : IPlanoContaService
{
    private MyFinanceDbContext myFinanceDbContext;

    public PlanoContaService(
        ILogger<HomeController> logger,
        MyFinanceDbContext myFinanceDbContext
    )
    {
        this.myFinanceDbContext = myFinanceDbContext;
    }

    public void Excluir(int id)
    {
        throw new NotImplementedException();
    }

    public List<PlanoConta> ListarRegistros()
    {
        var list = myFinanceDbContext.PlanoConta.ToList();
        return list;
    }

    public PlanoConta RetornarRegistro(int id)
    {
        throw new NotImplementedException();
    }

    public void Salvar(PlanoConta item)
    {
        throw new NotImplementedException();
    }
}
