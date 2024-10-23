using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order foundOrder = Order.Find(orderId);
      Vendor foundVendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object> ();
      model.Add("order", foundOrder);
      model.Add("vendor", foundVendor);
      return View(model);
    }

  }
}