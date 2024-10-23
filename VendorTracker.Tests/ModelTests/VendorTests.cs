using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      Vendor newVendor1 = new Vendor("name 1", "description 1");
      Vendor newVendor2 = new Vendor("name 2", "description 2");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> allVendors = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, allVendors);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor1 = new Vendor("name 1", "description 1");
      Vendor newVendor2 = new Vendor("name 2", "description 2");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      Order newOrder = new Order("title", "description", "price", "date");
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor("name", "description");
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithId_Int()
    {
      Vendor newVendor = new Vendor("name", "description");
      int id = newVendor.Id;
      Assert.AreEqual(1, id);
    }
  }
}