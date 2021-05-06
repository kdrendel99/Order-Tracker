using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
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
      Order newOrder = new Order("name","description","test","test","test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string testName = "Coava Coffee";
      Order newOrder = new Order("Coava Coffee","the description","test","test","test");
      string result = newOrder.Name;
      Assert.AreEqual(testName, result);     
    }

    [TestMethod]
    public void SetOrderName_SetNameString()
    {
      string name = "Bobs Coffee";
      Order newOrder = new Order(name, "description","test","test","test");
      string updatedName = "Marks Coffee";
      newOrder.Name = updatedName;
      string result = newOrder.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyOrderList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string name1 = "Order One";
      string name2 = "Order Two";
      Order newOrder1 = new Order(name1,"des","test","test","test");
      Order newOrder2 = new Order(name2,"des","test","test","test");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

      [TestMethod]
      public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
      {
      string name = "Bob";
      Order newOrder = new Order(name,"des","test","test","test");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string name1 = "Order 1";
      string name2 = "Order 2";
      Order newOrder1 = new Order(name1, "des1","test","test","test");
      Order newOrder2 = new Order(name2, "des2","test","test","test");
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}