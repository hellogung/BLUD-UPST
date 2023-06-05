using Microsoft.AspNetCore.Mvc;

namespace UPST.Controllers
{
    public class KontakController : Controller
    {
        [HttpGet("/kontak")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
