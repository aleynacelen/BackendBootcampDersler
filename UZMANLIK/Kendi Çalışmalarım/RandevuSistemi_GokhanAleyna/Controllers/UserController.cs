using Microsoft.AspNetCore.Mvc;
using RandevuSistemi_GokhanAleyna.RandevuSistemiData;

namespace RandevuSistemi_GokhanAleyna.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        public UserController(AppDbContext context)
        {
            _context=context;
        }
        public ActionResult Index()
        {
            var user = _context.Users.ToList();

            return View(user);
        }

    }
}
