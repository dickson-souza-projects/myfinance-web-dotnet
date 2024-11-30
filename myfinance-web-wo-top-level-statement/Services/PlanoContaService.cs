using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Extensions.Logging;

using myfinance.web.Controllers;
using myfinance.web.Domain;
using myfinance.web.Infrastructure;
using myfinance.web.Models;

namespace myfinance.web.Services;

public class PlanoContaService : IPlanoContaService
{
    private readonly MyFinanceDbContext myFinanceDbContext;

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

    public void Salvar(PlanoContaModel requestItem)
    {
        if (requestItem == null)
        {
            return;
        }

        var dbSet = myFinanceDbContext.PlanoConta;

        var item = new PlanoConta()
        {
            Nome = requestItem.Nome,
            Tipo = requestItem.Tipo
        };

        if(requestItem.Id == null)
        {
            dbSet.Add(item);
        }
        else
        {
            item.Id = (int)requestItem.Id;

            dbSet.Attach(item);
            myFinanceDbContext.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        myFinanceDbContext.SaveChanges();
    }
}
