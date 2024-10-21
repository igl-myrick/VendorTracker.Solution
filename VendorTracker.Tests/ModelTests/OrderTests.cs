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
      Order newOrder = new Order("title", "description", "price", "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "title";
      Order newOrder = new Order(title, "description", "price", "date");
      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void SetTitle_UpdatesTitle_String()
    {
      string title = "title";
      Order newOrder = new Order(title, "description", "price", "date");
      string newTitle = "new title";
      newOrder.Title = newTitle;
      string result = newOrder.Title;
      Assert.AreEqual(newTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "description";
      Order newOrder = new Order("title", description, "price", "date");
      Assert.AreEqual(description, newOrder.Description);
    }

    [TestMethod]
    public void SetDescription_UpdatesDescription_String()
    {
      string description = "description";
      Order newOrder = new Order("title", description, "price", "date");
      string newDescription = "new description";
      newOrder.Description = newDescription;
      string result = newOrder.Description;
      Assert.AreEqual(newDescription, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_String()
    {
      string price = "price";
      Order newOrder = new Order("title", "description", price, "date");
      Assert.AreEqual(price, newOrder.Price);
    }

    [TestMethod]
    public void SetPrice_UpdatesPrice_String()
    {
      string price = "price";
      Order newOrder = new Order("title", "description", price, "date");
      string newPrice = "new price";
      newOrder.Price = newPrice;
      string result = newOrder.Price;
      Assert.AreEqual(newPrice, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "date";
      Order newOrder = new Order("title", "description", "price", date);
      Assert.AreEqual(date, newOrder.Date);
    }

    [TestMethod]
    public void SetDate_UpdatesDate_String()
    {
      string date = "date";
      Order newOrder = new Order("title", "description", "price", date);
      string newDate = "new date";
      newOrder.Date = newDate;
      string result = newOrder.Date;
      Assert.AreEqual(newDate, result);
    }
  }
}