using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
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
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
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
      string result = newOrder.Price;
      Assert.AreEqual(price, result);
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
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
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

    [TestMethod]
    public void GetAll_ReturnsAllOrders_OrderList()
    {
      Order newOrder1 = new Order("title 1", "description 1", "price 1", "date 1");
      Order newOrder2 = new Order("title 2", "description 2", "price 2", "date 2");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> allOrders = Order.GetAll();

      CollectionAssert.AreEqual(newList, allOrders);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithId_Int()
    {
      Order newOrder = new Order("title", "description", "price", "date");
      int id = newOrder.Id;
      Assert.AreEqual(1, id);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      Order newOrder1 = new Order("title 1", "description 1", "price 1", "date 1");
      Order newOrder2 = new Order("title 2", "description 2", "price 2", "date 2");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}