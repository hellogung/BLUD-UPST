using Microsoft.AspNetCore.Mvc;

namespace UPST.Controllers
{
    public class ProdukController : Controller
    {
        [HttpGet("/produk")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
