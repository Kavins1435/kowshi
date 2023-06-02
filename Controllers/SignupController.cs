using Microsoft.AspNetCore.Mvc;

namespace hotelproject.Controllers
{
    public class SignupController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }
    }
}
