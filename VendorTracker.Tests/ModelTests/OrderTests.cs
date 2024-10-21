using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      Order newOrder = new Order();
      string title = newOrder.Title;
      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void SetTitle_UpdatesTitle_String()
    {
      Order newOrder = new Order();
      string newTitle = "title";
      newOrder.Title = newTitle;
      Assert.AreEqual(newTitle, newOrder.Title);
    }
  }
}