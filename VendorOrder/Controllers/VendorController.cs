using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Controllers
{
    public class VendorController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}