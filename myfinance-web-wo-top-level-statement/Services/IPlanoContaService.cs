using System.Collections.Generic;

using myfinance.web.Domain;

namespace myfinance.web.Services;

public interface IPlanoContaService
{
    List<PlanoConta> ListarRegistros();

    void Salvar(PlanoConta item);

    void Excluir(int id);

    PlanoConta RetornarRegistro(int id);
}
