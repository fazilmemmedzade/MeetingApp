using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Bakı, 28 may",
                Date = new DateTime(DateTime.Now.Year + 1, 5, 15, 12, 0, 0),
                NumberOfPeople = UserCount
            };

            return View(meetingInfo);
        }
    }
}