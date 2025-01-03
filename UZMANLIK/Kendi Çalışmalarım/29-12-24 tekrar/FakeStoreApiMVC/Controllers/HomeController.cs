using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FakeStoreApiMVC.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using System.Text;

namespace FakeStoreApiMVC.Controllers;

public class HomeController : Controller
{
    private readonly HttpClient _httpClient;

    public HomeController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("FakeStoreApi");
    }

    public async Task<IActionResult> Index()
    {
        HttpResponseMessage responseMessage = await _httpClient.GetAsync("products");
        string contentResponse = await responseMessage.Content.ReadAsStringAsync();
        List<Product>? response = JsonConvert.DeserializeObject<List<Product>>(contentResponse);


        return View(response);
    }

    public async Task<IActionResult> Details(int id)
    {
        var responseMessage = await _httpClient.GetAsync($"products/{id}");
        var contentResponse = await responseMessage.Content.ReadAsStringAsync();
        var response = JsonConvert.DeserializeObject<Product>(contentResponse);
        return View(response);
    }

    public async Task<IActionResult> GetCategories()
    {
        var responseMessage = await _httpClient.GetAsync("products/categories");
        var contentResponse = await responseMessage.Content.ReadAsStringAsync();
        var response = JsonConvert.DeserializeObject<List<string>>(contentResponse);
        return View(response);
    }

    public async Task<IActionResult> AddProduct()
    {
        var responseMessage = await _httpClient.GetAsync("products/categories");
        var contentResponse = await responseMessage.Content.ReadAsStringAsync();
        var categories = JsonConvert.DeserializeObject<List<string>>(contentResponse);
        ViewBag.Categories = categories;
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddProduct(Product product)
    {
        if (ModelState.IsValid)
        {
            // var response = await _httpClient.PostAsJsonAsync("products", product);
            var serializeProduct = JsonConvert.SerializeObject(product);
            HttpContent content = new StringContent(serializeProduct, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("products", content);
            var newProduct = response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Product>(newProduct.Result);
            return Json(result);
        }
        var responseMessage = await _httpClient.GetAsync("products/categories");
        var contentResponse = await responseMessage.Content.ReadAsStringAsync();
        var categories = JsonConvert.DeserializeObject<List<string>>(contentResponse);
        ViewBag.Categories = categories;
        return View(product);
    }

}
// İlk önce sln dosyası açtım ve mvc projesi oluşturdum sonra homecontrollerda sadece index actionu oluşturdum ve içine fakestoreapi.com/products adresine get request attım ve gelen responseu okudum.
//daha sonra  models klasörüne product ve rating classlarını oluşturdum ve içlerine gerekli propertyleri ekledim.
//newtonsoft.json paketini yükledim ve product ve rating classlarını json formatına çevirdim ve index actionunda bu json formatındaki responseu product listesine çevirdim ve viewa gönderdim.
//appsettings.json dosyasına fakestoreapi.com adresini ekledim ve appsettings.json dosyasını okuyarak bu adresi kullanabilirim.
//modelde apisetting classı oluşturup ve program cs de kullanarak bu adresi okudum ve kullanabilirim.
//intex.cshtml dosyasında 
//daha sonra details actionu oluşturdum ve fakestoreapi.com/products/{id} adresine get request attım ve gelen responseu okudum ve product classına çevirdim ve viewa gönderdim.
