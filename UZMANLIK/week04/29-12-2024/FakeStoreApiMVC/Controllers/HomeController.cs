using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FakeStoreApiMVC.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;

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
       var response =JsonConvert.DeserializeObject<Product>(contentResponse);
         return View(response);
    }

    

}
