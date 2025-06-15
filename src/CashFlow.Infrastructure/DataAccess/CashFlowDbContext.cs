using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

public class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=127.0.0.1;Database=cashflowdb;Uid=Natapires;Pwd=22061998Nata;";

        var version = new Version(8, 0, 42);
        var serverVersion = new MySqlServerVersion(version);

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}