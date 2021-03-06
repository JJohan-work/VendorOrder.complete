using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
    public class VendorController : Controller
    {

      [HttpGet("/Vendors")]
      public ActionResult Index()
      {
        return View(Vendor.GetAll());
      }

      [HttpPost("/Vendors")]
      public ActionResult New(string VendorName, string VendorDesc)
      {
        Vendor newVendor = new Vendor(VendorName, VendorDesc);
        return RedirectToAction("Index");
      }

      [HttpGet("/Vendor/New")]
      public ActionResult New()
      {
        return View();
      }

      [HttpGet("/Vendor/{id}")]
      public ActionResult Show(int id)
      {
        Vendor selectedVendor = Vendor.Find(1);
        return View(selectedVendor);
      }

    }
}