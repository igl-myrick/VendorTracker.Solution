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
      Order newOrder = new Order("title");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "title";
      Order newOrder = new Order(title);
      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void SetTitle_UpdatesTitle_String()
    {
      string title = "title";
      Order newOrder = new Order(title);
      string newTitle = "new title";
      newOrder.Title = newTitle;
      string result = newOrder.Title;
      Assert.AreEqual(newTitle, result);
    }
  }
}