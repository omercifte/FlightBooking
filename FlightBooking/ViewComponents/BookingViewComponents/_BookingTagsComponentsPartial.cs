using Microsoft.AspNetCore.Mvc;

namespace FlightBooking.ViewComponents.BookingViewComponents
{
    public class _BookingTagsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke(List<string> tags)
        {
            return View(tags);
        }
    }
}
