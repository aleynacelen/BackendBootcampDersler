using System;
using Microsoft.EntityFrameworkCore;
using Tekrar.Entity.Contrate;

namespace Tekrar.Data.Concrete.Context;

public class AppDbContext:DbContext
{
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1441;Database=EfCoreIntroDb;User=SA;Password=YourStrong@Passw0rd;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);
    }
}
 