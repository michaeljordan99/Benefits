using Microsoft.AspNetCore.Mvc;

namespace Benefits.Controllers
{
    public class BenefitsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
