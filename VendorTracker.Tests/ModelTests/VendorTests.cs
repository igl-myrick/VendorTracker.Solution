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
      Vendor newVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "name";
      Vendor newVendor = new Vendor(name, "description");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void SetName_UpdatesName_String()
    {
      string name = "name";
      Vendor newVendor = new Vendor(name, "description");
      string newName = "new name";
      newVendor.Name = newName;
      string result = newVendor.Name;
      Assert.AreEqual(newName, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "description";
      Vendor newVendor = new Vendor("name", description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_UpdatesDescription_String()
    {
      string description = "description";
      Vendor newVendor = new Vendor("name", description);
      string newDescription = "new description";
      newVendor.Description = newDescription;
      string result = newVendor.Description;
      Assert.AreEqual(newDescription, result);
    }
  }
}