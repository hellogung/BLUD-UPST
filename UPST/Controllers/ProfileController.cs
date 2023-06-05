using Microsoft.AspNetCore.Mvc;

namespace UPST.Controllers
{
    public class ProfileController : Controller
    {

        // Profil
        [HttpGet("/profil/tentang-kami")]
        public IActionResult Index() => View();

        [HttpGet("/profil/struktur-organisasi")]
        public IActionResult StrukturOrganisasi() => View();

        [HttpGet("/profil/galeri")]
        public IActionResult Galeri() => View();

    }
}
