using Microsoft.AspNetCore.Mvc;

namespace BookCart.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
