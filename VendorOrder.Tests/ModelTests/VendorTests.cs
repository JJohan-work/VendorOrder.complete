using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrder.Models;

namespace VendorOrder.Tests
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
      Vendor newVendor = new Vendor("VendorCo","VendorDesc");

      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void Getname_ReturnsName_String()
    {
      string name = "VendorCo";
      Vendor testVendor = new Vendor(name, "VendorDesc");

      string result = testVendor.Name;

      Assert.AreEqual(name,result);
    }

    [TestMethod]
    public void GetDesc_ReturnsDescription_String()
    {
      string testDesc = "VendorDesc";
      Vendor testVendor = new Vendor("VendorCo",testDesc);

      string result = testVendor.Desc;

      Assert.AreEqual(testDesc,result);
    }

    [TestMethod]
    public void GetId_ReturnsId_int()
    {
      int expectedId = 1;
      Vendor testVendor = new Vendor("VendorCo","VendorDesc");

      int returnedId = testVendor.Id;

      Assert.AreEqual(expectedId, returnedId);
    }

    [TestMethod]
    public void GetBalance_ReturnsBalanceOfVendor_int()
    {
      int expectedBalance = 0;
      Vendor testVendor = new Vendor("VendorCo", "VendorDesc");

      int returnedBalance = testVendor.Balance;

      Assert.AreEqual(expectedBalance, returnedBalance);
    }
    [TestMethod]
    public void Find_ReturnsVendorObjectById_Vendor()
    {
      Vendor testVendor = new Vendor("VendorCo", "VendorDesc");

      Vendor returnedVendor = Vendor.Find(1);

      Assert.AreEqual(testVendor, returnedVendor);
    }
  }
}

//Methods to test

  //Calculate Balance
  //Find Category
  //Get all Categories
  //Get all orders
  //Get specific order
  //Add order
  //Remove all orders
  //Remove specific order