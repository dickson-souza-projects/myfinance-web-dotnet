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

    public PlanoContaModel RetornarRegistro(int id)
    {
        var registro = myFinanceDbContext.PlanoConta.Where(x => x.Id == id).FirstOrDefault();
        PlanoContaModel? planoContaModel = null;

        if (registro != null)
        {
            planoContaModel = registro.ConvertToPlanoContaModel();
        }

        if (planoContaModel != null)
        {
            return planoContaModel;
        }
        else
        {
            throw new ArgumentOutOfRangeException($"Registro cujo id = {id} não foi encontrado!");
        }
    }

    public void Salvar(PlanoContaModel requestItem)
    {
        PlanoConta? item;
        if (requestItem.IsValid())
        {
            item = requestItem.ConvertToPlanoConta();
        }
        else
        {
            return;
        }

        if (item == null)
        {
            return;
        }

        var dbSet = myFinanceDbContext.PlanoConta;

        if (requestItem.Id == null)
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
