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

    [TestMethod]
    public void GetAll_ReturnsListOfVendorObjects_VendorList()
    {
      Vendor testVendor1 = new Vendor("VendorCo1", "VendorDesc1");
      Vendor testVendor2 = new Vendor("VendorCo2", "VendorDesc2");

      List<Vendor> expectedList = new List<Vendor> {testVendor1, testVendor2};

      Assert.AreEqual(expectedList[0].Name,Vendor.GetAll()[0].Name);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendorOrders_void()
    {
      Vendor testVendor = new Vendor("VendorCo", "VendorDesc");
      Order testOrder = new Order("Bread",10);

      testVendor.AddOrder(testOrder);

      Assert.AreEqual(testOrder, testVendor.Orders[0]);
    }

    [TestMethod]
    public void GetAllOrders_ReturnsAllOrdersInVendorOrder_OrderList()
    {
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10);
      Order testOrder2 = new Order("Pastry",20);
      testVendor.AddOrder(testOrder);
      testVendor.AddOrder(testOrder2);
      List<Order> expectedList = new List<Order> {testOrder, testOrder2};

      List<Order> returnedList = testVendor.GetAllOrders();

      Assert.AreEqual(expectedList.GetType(), returnedList.GetType());
    }

    [TestMethod]
    public void GetOrder_ReturnsSpecificOrderById_Order()
    {
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10);
      testVendor.AddOrder(testOrder);

      Order returnedOrder = testVendor.GetOrder(1);

      Assert.AreEqual(returnedOrder,testOrder);
    }
    public void RemoveOrder_RemovesSpecificOrderById_Void()
    {
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10);
      testVendor.AddOrder(testOrder);

      testVendor.RemoveOrder(1);

      Assert.AreEqual(testVendor.Orders.Count,0);
    }

    public void RemoveAllOrders_RemovesAllOrdersInVendor_Void()
    {
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10);
      testVendor.AddOrder(testOrder);

      testVendor.RemoveAllOrders();

      Assert.AreEqual(testVendor.Orders.Count,0);
    }
  }
}

//Methods to test
  //Calculate Balance