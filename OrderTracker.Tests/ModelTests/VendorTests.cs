using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
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
      Vendor newVendor = new Vendor("name","description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string testName = "Coava Coffee";
      Vendor newVendor = new Vendor("Coava Coffee","the description");
      string result = newVendor.Name;
      Assert.AreEqual(testName, result);     
    }

    [TestMethod]
    public void SetVendorName_SetNameString()
    {
      string name = "Bobs Coffee";
      Vendor newVendor = new Vendor(name, "description");
      string updatedName = "Marks Coffee";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyVendorList_VendorList()
    {
      List<Vendor> newList = new List<Vendor> { };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      string name1 = "Vendor One";
      string name2 = "Vendor Two";
      Vendor newVendor1 = new Vendor(name1,"des");
      Vendor newVendor2 = new Vendor(name2,"des");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

      [TestMethod]
      public void GetId_VendorsInstantiateWithAnIdAndGetterReturns_Int()
      {
      string name = "Bob";
      Vendor newVendor = new Vendor(name,"des");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Vendor 1";
      string name2 = "Vendor 2";
      Vendor newVendor1 = new Vendor(name1, "des1");
      Vendor newVendor2 = new Vendor(name2, "des2");
      Vendor result = new Vendor("Incorrect test vendor", "irrelevant");
      Assert.AreEqual(newVendor2, result);
    }
  }
}