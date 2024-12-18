using Microsoft.EntityFrameworkCore;
using RandevuSistemi_GokhanAleyna.RandevuSistemiData;
using RandevuSistemi_GokhanAleyna.RandevuSistemiData; // AppDbContext'i içeren namespace'i ekleyin

var builder = WebApplication.CreateBuilder(args);

// Bağlantı dizesini almak ve DbContext'i kullanıma sunmak için
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); // appsettings.json'daki bağlantı dizesini kullan

// Diğer servisleri ekleyin
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Uygulama yapılandırmasını yapın
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");





