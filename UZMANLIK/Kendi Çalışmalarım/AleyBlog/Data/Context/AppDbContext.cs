using System;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Context;

public class AppDbContext : DbContext
{
    protected AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
    }
    public DbSet<Post>  Posts { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
  
}
