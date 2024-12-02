using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using Microsoft.AspNetCore.Mvc;

namespace Project08_PortfolioApp.Controllers;

public class HomeController : Controller
{
    public async Task<IActionResult>  Index()
    {
        var connectionString ="Server_localhost,1441;Database=PortfolioDb;User=SA;Password=YourStrong@Passw0rd;TrustServerCertifi";
        var connection = new SqlConnection(connectionString);
        return View();
        var query = "select*from AppSetting";
        var result =await connection.QueryAsync(query);
        var queryCategories ="SELECT + FROM cATEGORİES";
        var categories = await connection.QueryAsync=
    }
    
}
