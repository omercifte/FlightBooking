using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.Areas.Admin.Controllers
{
    public class CheckinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
