using _29_12_2024.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
//ApiSetting konfşgüre edilir
builder.Services.Configure<ApiSetting>(builder.Configuration.GetSection("FakeStoreApi"));
//HttpClient ApiSetting ile konfigüre edilir    
builder.Services.AddHttpClient("FakeStoreApi",(ServiceProvider,client)=>
{
   var apiSetting = ServiceProvider.GetRequiredService<IOptions<ApiSetting>>().Value;
   client.BaseAddress=new Uri(apiSetting.BaseUrl);
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
