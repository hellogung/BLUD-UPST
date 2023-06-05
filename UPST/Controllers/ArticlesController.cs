using Microsoft.AspNetCore.Mvc;

namespace UPST.Controllers
{
    public class ArticlesController : Controller
    {
        [HttpGet("/artikel")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }


    }
}
