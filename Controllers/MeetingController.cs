using Microsoft.AspNetCore.Mvc;


namespace MeetingApp.Controllers
{


    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        public IActionResult Apply(string Name, string Email, string Phone, bool WillAttend){
            Console.WriteLine(Name,Email,Phone,WillAttend);
            return View();
        }
        public IActionResult List(){
            return View();
        }
    }
}