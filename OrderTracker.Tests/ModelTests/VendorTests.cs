using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
    [TestClass]
  public class CategoryTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor= new Vendor("test vendor","des");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name,"des");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name,"des");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

      [TestMethod]
  public void GetAll_ReturnsAllVendorObjects_VendorList()
  {
    string name01 = "Vendor 1";
    string name02 = "Vendor 2";
    Vendor newVendor1 = new Vendor(name01,"des");
    Vendor newVendor2 = new Vendor(name02,"des2");
    List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
    List<Vendor> result = Vendor.GetAll();
    CollectionAssert.AreEqual(newList, result);
  }

    [TestMethod]
  public void Find_ReturnsCorrectCategory_Category()
  {
    string name01 = "Vendor 1";
    string name02 = "Vendor 2";
    Vendor newVendor1 = new Vendor(name01,"des");
    Vendor newVendor2 = new Vendor(name02,"des2");
    Vendor result = Vendor.Find(2);
    Assert.AreEqual(newVendor2, result);
  }

  [TestMethod]
  public void AddOrder_AssociatesItemWithVendor_OrderList()
  {
    Order newOrder = new Order("name1", "des1","test","test");
    List<Order> newList = new List<Order> { newOrder };
    Vendor newVendor = new Vendor("bob saget","des");
    newVendor.AddOrder(newOrder);
    List<Order> result = newVendor.Orders;
    CollectionAssert.AreEqual(newList, result);
  }
  }
}