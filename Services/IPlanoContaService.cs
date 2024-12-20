using System.Collections.Generic;

using myfinance.web.Domain;
using myfinance.web.Models;

namespace myfinance.web.Services;

public interface IPlanoContaService
{
    List<PlanoConta> ListarRegistros();

    int Salvar(PlanoContaModel requestItem);

    void Excluir(int id);

    PlanoContaModel RetornarRegistro(int id);
}
