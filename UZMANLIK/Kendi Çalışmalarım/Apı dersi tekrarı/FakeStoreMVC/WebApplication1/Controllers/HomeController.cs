using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly HttpClient _httpClient;

    public HomeController (IHttpClientFactory httpClientFacttory)
    {
        _httpClient _ httpClientFacttory.CreateClient(FakeStoreApi);


    }
    public async Task<IActionResult> Index()
    {
        HttpResponseMessage responseMessage = await _httpClient.GetAsync ("products");
        string contentResponse = await responseMessage.Conctent.ReadAsStringAsync();
        List<Product>products = JsonConvert.DeserializeObject<List<Product>>(contentResponse);
        return View(response);
    }
    public async Task<IActionResult> Details(int id)
    {
        var responseMessage= await HttpClient 
        HttpResponseMessage responseMessage = await _httpClient.GetAsync ("products");
        string contentResponse = await responseMessage.Conctent.ReadAsStringAsync();
        List<Product>products = JsonConvert.DeserializeObject<List<Product>>(contentResponse);
        return View(response);
    }





}

