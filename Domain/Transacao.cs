using System;

namespace myfinance.web.Domain;

public class Transacao
{
    public int Id { get; set; }

    public DateTime Data { get; set; }

    public decimal Valor { get; set; }

    public string Historico { get; set; }

    public string Tipo { get; set; }

    public string PlanoContaId { get; set; }

    public PlanoConta PlanoConta { get; set; }
}
