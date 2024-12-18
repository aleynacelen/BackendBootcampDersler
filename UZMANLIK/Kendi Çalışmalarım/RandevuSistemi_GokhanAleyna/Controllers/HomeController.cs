using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandevuSistemi_GokhanAleyna.Models;
using RandevuSistemi_GokhanAleyna.RandevuSistemiData;

namespace RandevuSistemi_GokhanAleyna.Controllers;

public class HomeController : Controller
{
 



   

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
   
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Home/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Date,Time,UserId")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointment);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(appointment);
        }
    public IActionResult Index()
    {
        var appointments = _context.Appointments.ToList();
        return View(appointments);
    }



}

