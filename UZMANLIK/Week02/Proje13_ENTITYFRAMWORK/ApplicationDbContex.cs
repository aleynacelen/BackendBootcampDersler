using System;
using Microsoft.EntityFrameworkCore;

namespace Proje13_ENTITYFRAMWORK;

public class ApplicationDbContex:DbContext
{
   public DbSet<Category> Categories { get; set; }
   public DbSet<Product> Products{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1441;Database=EfCoreIntroDb;User=SA;Password=YourStrong@Passw0rd;TrustServerCertificate=true;");
        base.OnConfiguring(optionsBuilder);

    }
}
