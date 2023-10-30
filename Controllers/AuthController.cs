using Microsoft.AspNetCore.Mvc;

namespace IT_LETI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
