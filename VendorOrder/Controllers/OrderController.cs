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

      [HttpGet("/Vendor/{VendId}/Order/New")]
      public ActionResult New(int vendId)
      {
        return View(Vendor.Find(vendId));
      }

      [HttpPost("/Vendor/{Id}/Orders")]
      public ActionResult Create(int Id, string Type, int Amount)
      {
        Vendor vendor = Vendor.Find(Id);
        Order newOrder = new Order(Type, Amount, Id);
        vendor.AddOrder(newOrder);
        return View(Id);
      }

      [HttpPost("/Vendor/{VendId}/Order/{Id}")]
      public ActionResult Destroy(int VendId, int Id)
      {
        
        return RedirectToAction("Show",new {VendId, Id});
      }
    }
}