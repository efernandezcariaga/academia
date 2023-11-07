using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Infraestructure.Context;

public class AcademiaContext : DbContext
{
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Plan> Planes { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }

    public AcademiaContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // var server = "MS-03\\SQLEXPRESS";
        //var server = @"DESKTOP-DO7U7JF\SQLEXPRESS";
        var server = @".\SQLEXPRESS";

        var databaseName = "AcademiaDB";
        var userId = "net";
        var password = "net";

        var connectionString = @$"
                Server={server};
                Initial Catalog={databaseName};
                User Id={userId};
                Password={password};
                Database={databaseName};
                TrustServerCertificate=True;";

        //var connectionString = @$"
        //        Server={server};
        //        Initial Catalog={databaseName};
        //        Database={databaseName};
        //        Integrated Security=True;
        //        TrustServerCertificate=True;";

        optionsBuilder.UseSqlServer(connectionString);
        
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }
}
