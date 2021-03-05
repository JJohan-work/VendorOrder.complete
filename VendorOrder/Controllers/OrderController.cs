using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Controllers
{
    public class OrderController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}