using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace UPST.Controllers
{
    public class PengelolaanSampahController : Controller
    {

        // TPST Bantargebang
        [HttpGet("/tpst-bantargebang/ringkasan")]
        public IActionResult TPSTRingkasan() =>  View("~/Views/PengelolaanSampah/TPST/Ringkasan.cshtml");
        [HttpGet("/tpst-bantargebang/data")]
        public IActionResult TPSTData() => View("~/Views/PengelolaanSampah/TPST/Data.cshtml");
        [HttpGet("/tpst-bantargebang/landfill")]
        public IActionResult TPSTLandfill() => View("~/Views/PengelolaanSampah/TPST/Landfill.cshtml");
        [HttpGet("/tpst-bantargebang/pltsa")]
        public IActionResult TPSTPLTSA() => View("~/Views/PengelolaanSampah/TPST/PLTSA.cshtml");
        [HttpGet("/tpst-bantargebang/faq")]
        public IActionResult TPSTFAQ() => View("~/Views/PengelolaanSampah/TPST/FAQ.cshtml");



        // PKM
        [HttpGet("/pkm/ringkasan")]
        public IActionResult PKMRingkasan() => View("~/Views/PengelolaanSampah/PKM/Ringkasan.cshtml");
        [HttpGet("/pkm/data")]
        public IActionResult PKMData() => View("~/Views/PengelolaanSampah/PKM/Data.cshtml");
        [HttpGet("/pkm/faq")]
        public IActionResult PKMFAQ() => View("~/Views/PengelolaanSampah/PKM/FAQ.cshtml");



        // ITF
        [HttpGet("/itf/ringkasan")]
        public IActionResult ITFRingkasan() => View("~/Views/PengelolaanSampah/ITF/Ringkasan.cshtml");
        [HttpGet("/itf/data")]
        public IActionResult ITFData() => View("~/Views/PengelolaanSampah/ITF/Data.cshtml");
        [HttpGet("/itf/faq")]
        public IActionResult ITFFAQ() => View("~/Views/PengelolaanSampah/ITF/FAQ.cshtml");



        // JRC
        [HttpGet("/jrc/ringkasan")]
        public IActionResult JRCRingkasan() => View("~/Views/PengelolaanSampah/JRC/Ringkasan.cshtml");
        [HttpGet("/jrc/mekanisme")]
        public IActionResult JRCMekanisme() => View("~/Views/PengelolaanSampah/JRC/Mekanisme.cshtml");

    }
}
