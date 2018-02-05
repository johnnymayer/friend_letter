using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeControler : Controller
    {
        [Route("/hello")]
        public string Hello() { return "Henlo fren!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbai fren!"; }

        [Route("/")]
        public ActionResult Letter()
        {
            return View();
        }

        [Route("/journal")]
        public ActionResult Journal()
        {
            return View();
        }
    }
}
