using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace coreIdentityApplication.Controllers
{
    [AllowAnonymous]
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Details() //  public IActionResult Details() => View();
        {
            return View();
        }
        [Authorize]
        public IActionResult Policy()
        {
            return View();
        }
    }
}
