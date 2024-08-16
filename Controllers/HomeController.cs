using Microsoft.AspNetCore.Mvc;


namespace MeetingApp.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            var selam = saat > 12 ? "İyi Günler" : "Günaydın";
            //return View(model:selam);
            //ViewBag.Selam = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewData["Selam"] = saat > 12 ? "İyi Günler" : "Günaydın";
            return View();
        }
    }
}