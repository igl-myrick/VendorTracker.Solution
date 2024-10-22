using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    public void GetName_ReturnsName_String()
    {
      Vendor newVendor = new Vendor();
      string name = newVendor.Name;
      Assert.AreEqual(name, newVendor.Name);
    }
  }
}