using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace UPST.Controllers

{
    public class ProdukHukumController : Controller
    {

        [HttpGet("/produk-hukum")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
