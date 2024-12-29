using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _29_12_2024.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Options;

namespace _29_12_2024.Controllers;

public class HomeController : Controller
{
    private readonly HttpClient _httpClient;

    public HomeController(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IActionResult> Index()
    {
     
        using (HttpClient httpClient =new())
        {

            HttpResponseMessage responseMessage = await _httpClient.GetAsync("products");
            string contentResponse = await responseMessage.Content.ReadAsStringAsync();
           List<Product> ? response = JsonConvert.DeserializeObject>List<Product>>(contentResponse);

        }
        return View(response);
    }

   

   
    
}
