using FakeStoreApiMVC.Models;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//ApiSetting configuration ediliyor
builder.Services.Configure<ApiSetting>(builder.Configuration.GetSection("FakeStoreApi"));
//HttpClient Api seting ile configure ediliyor
builder.Services.AddHttpClient("FakeStoreApi",(serviceProvider,client)=>
{
    var apiSetting = serviceProvider.GetRequiredService<IOptions<ApiSetting>>().Value;
    client.BaseAddress = new Uri(apiSetting.BaseUrl);
});










var app = builder.Build();


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
