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
        optionsBuilder.UseSqlServer(@"Server=MS-03\SQLEXPRESS;Initial Catalog=AcademiaDB_1;User Id=net;Password=net;Database=AcademiaDB_1;TrustServerCertificate=True;");
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }
}
