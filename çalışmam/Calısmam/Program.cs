var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run()
public class MinMaxFinder
{
    public(int min, int max) FindMindMax(int[] array)
    {
        if(array ==null|| array.Length==0)
        throw new ArgumentExpection("Dizi boş olamaz")
        int min = array[0];
        int max = array[0];
        for(int i =1; i<array.Length; i++)
        {
            if(array[i]<min)
            min = array[i];
            if(array[i]> max)
            max = array[i];
        }
        return(min,max);
    }
    public int MyProperty { get; set; }
    public int ..boş
}
