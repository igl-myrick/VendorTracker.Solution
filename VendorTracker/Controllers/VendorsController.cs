using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

  }
}