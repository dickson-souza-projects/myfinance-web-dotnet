using myfinance.web.Domain;

namespace myfinance.web.Models;

public static class PlanoContaModelExtensions
{
    public static bool IsValid(this PlanoContaModel planoContaModel)
    {
        if (planoContaModel == null)
        {
            return false;
        }

        if (planoContaModel.Nome == null) 
        { 
            return false; 
        }

        if (planoContaModel.Tipo == null)
        {
            return false;
        }

        return true;
    }

    public static PlanoConta? ConvertToPlanoConta(this PlanoContaModel model)
    {
        if (model.Nome == null || model.Tipo == null)
        {
            return null;
        }

        var item = new PlanoConta()
        {
            Nome = model.Nome,
            Tipo = model.Tipo
        };

        return item;
    }

    public static PlanoContaModel? ConvertToPlanoContaModel(this PlanoConta planoConta)
    {
        if (planoConta == null)
        {
            return null;
        }

        var item = new PlanoContaModel()
        {
            Id = planoConta.Id,
            Nome = planoConta.Nome,
            Tipo = planoConta.Tipo
        };

        return item;
    }
}
