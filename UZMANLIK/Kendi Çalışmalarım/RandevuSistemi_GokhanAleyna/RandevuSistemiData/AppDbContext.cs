using System;
using Microsoft.EntityFrameworkCore;
using RandevuSistemi_GokhanAleyna.Models;

namespace RandevuSistemi_GokhanAleyna.RandevuSistemiData;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // DbSetlerimiz Entity Framework'ün veritabanı tablosuyla eşleşmesini sağlar.
    public DbSet<User> Users { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}
