using EnglishCourseReg.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnglishCourseReg.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Доброго дня";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            if (ModelState.IsValid)
                // Нужно отправить данные нового гостя по электронной почте 
                return View("Thanks", guest);
            else
                // Обнаружена ошибка проверки достоверности
                return View();
        }
    }
}