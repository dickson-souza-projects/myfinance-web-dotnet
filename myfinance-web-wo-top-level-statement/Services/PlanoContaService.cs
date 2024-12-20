using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;
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
        var planoContaModelItem = RetornarRegistro(id);
        var planoContaItem = planoContaModelItem.ConvertToPlanoConta();

        try
        {
            if (planoContaItem != null)
            {
                myFinanceDbContext.Remove(planoContaItem);
                myFinanceDbContext.SaveChanges();
            }
        }
        catch
        {
            var errorMessage = "Esse item não pode ser deletado pois há transações vinculadas a ele.";
            throw new InvalidOperationException(errorMessage);
        }
    }

    public List<PlanoConta> ListarRegistros()
    {
        var list = myFinanceDbContext.PlanoConta.ToList();
        return list;
    }

    public PlanoContaModel RetornarRegistro(int id)
    {
        var registro = myFinanceDbContext.PlanoConta.Where(x => x.Id == id).AsNoTracking().FirstOrDefault();
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

    public int Salvar(PlanoContaModel requestItem)
    {
        PlanoConta? item;
        if (requestItem.IsValid())
        {
            item = requestItem.ConvertToPlanoConta();
        }
        else
        {
            return -1;
        }

        if (item == null)
        {
            return -1;
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

        return item.Id;
    }
}
