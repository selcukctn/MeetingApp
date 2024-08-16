using MeetingApp.Models;
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

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul, Abc Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = 100
            };
            return View(meetingInfo);
        }
    }
}