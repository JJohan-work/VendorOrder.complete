using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrder.Models;

namespace VendorOrder.Controllers
{
    public class OrderController : Controller
    {

      [HttpGet("/Orders")]
      public ActionResult Index()
      {
        List<Order> allOrders = Order.GetAll();

        return View(allOrders);
      }

      [HttpGet("/Vendor/{vendId}/Order/{orderId}")]
      public ActionResult Show(int vendId, int orderId)
      {
        Order order = Vendor.Find(vendId).GetOrder(orderId);

        return View(order);
      }
      [HttpGet("/Vendor/{vendId}/Orders")]
      public ActionResult VendIndex(int vendId)
      {
        Vendor Vendor = Vendor.Find(vendId);
        return View(Vendor);
      }

      [HttpGet("/Vendors/{VendId}/Order/New")]
      public ActionResult New(int vendId)
      {
        return View(vendId);
      }
    }
}