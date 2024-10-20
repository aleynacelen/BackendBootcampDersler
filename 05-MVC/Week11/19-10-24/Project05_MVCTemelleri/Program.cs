var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();//bir web application oluşturucu 
//bu satırla bu uygulamanın bir mvc uygulamsı olduğu bilidiriliyor.
var app = builder.Build();

// Configure the HTTP request pipeline.
// bu aşamadan run yapılana kadar olan kısımda gelen istekler yapılandırılıyor
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();//http üzerinden gelen istekleri https'e yönlendirir
app.UseStaticFiles();//wwroot klasörünün kullanabilrir olmasını sağlar

app.UseRouting();//Gelen isteklerin hangi controllera gitmesi gerektiğini belirler

app.UseAuthorization();//Yetkilendirme özelliklerini aktif kılar

app.MapControllerRoute( 
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//https://localhost:5100/Home/Index
//https://localhost:5100/Home
//https://localhost:5100
//https://localhost:5100
//https://localhost:5100
//https://localhost:5100



app.Run();
