using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SayiGiris()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SayiGiris(int kucukSayi, int buyukSayi)
        {
            if(kucukSayi >= buyukSayi)
            {
                TempData["msg"] = "Üst limit alt limitten küçük veya eşit olmaz";
                return View("index");
            }
            else
            {
                double fark = buyukSayi - kucukSayi;
                return Ok($"Fark{fark}");   
            }
            
        }
        public IActionResult Soru2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Soru2(Kayit kayit)
        {
            return View();
        }

    }
}
