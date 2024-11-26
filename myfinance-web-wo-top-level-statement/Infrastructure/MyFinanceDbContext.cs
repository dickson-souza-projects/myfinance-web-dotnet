using Microsoft.EntityFrameworkCore;

using myfinance.web.Domain;

namespace myfinance.web.Infrastructure;

public class MyFinanceDbContext : DbContext
{
    public DbSet<PlanoConta> PlanoConta { get; set; }

    public DbSet<Transacao> Transacao { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "";
        optionsBuilder.UseSqlServer(connectionString);

    }
}
