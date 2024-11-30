using System.Collections.Generic;

using myfinance.web.Domain;
using myfinance.web.Models;

namespace myfinance.web.Services;

public interface IPlanoContaService
{
    List<PlanoConta> ListarRegistros();

    void Salvar(PlanoContaModel item);

    void Excluir(int id);

    PlanoConta RetornarRegistro(int id);
}
