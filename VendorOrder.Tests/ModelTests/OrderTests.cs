using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorOrder.Models;

namespace VendorOrder.Tests
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
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10,testVendor.Id);
      testVendor.AddOrder(testOrder);

      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetType_ReturnsTypeOfOrder_string()
    {
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10,testVendor.Id);
      testVendor.AddOrder(testOrder);
      string expectedType = "Bread";

      string returnedType = testOrder.Type;

      Assert.AreEqual(expectedType, returnedType);
    }

    [TestMethod]
    public void GetId_ReturnsIdOfOrder_int()
    {
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10,testVendor.Id);
      testVendor.AddOrder(testOrder);
      int expectedId = 1;

      int returnedId = testOrder.Id;

      Assert.AreEqual(expectedId,returnedId);
    }

    [TestMethod]
    public void GetAmount_ReturnsAmountofOrder_int()
    {
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10,testVendor.Id);
      int expectedAmount = 10;

      int returnedAmount = testOrder.Amount;

      Assert.AreEqual(expectedAmount, returnedAmount);
    }

    [TestMethod]
    public void RemoveOrder_RemovesOrderAtId_void()
    {
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10,testVendor.Id);
      Order testOrder2 = new Order("Pastry",20,testVendor.Id);
      testVendor.AddOrder(testOrder);
      testVendor.AddOrder(testOrder2);

      Order.RemoveOrder(1);

      Assert.AreEqual(Order.GetAll()[0],testOrder2);
    }

    [TestMethod]
    public void TogglePayment_TogglesPayedStatus_void()
    {
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10,testVendor.Id);
      testVendor.AddOrder(testOrder);

      testOrder.TogglePayment();

      Assert.AreEqual(testOrder.Payed,true);
    }
    
    [TestMethod]
    public void ToggleFulfill_TogglesFulfilledStatus_void()
    {
      Vendor testVendor = new Vendor("VendorCo1", "VendorDesc1");
      Order testOrder = new Order("Bread",10,testVendor.Id);
      testVendor.AddOrder(testOrder);

      testOrder.ToggleFulfill();

      Assert.AreEqual(testOrder.Fulfilled,true);
    }
  }
}



    // [TestMethod]
    // public void GetOrder_ReturnsOrderSpecifiedById_Order()
    // {

    // }

    // [TestMethod]
    // public void SetPayed_SetsBoolOfOrderPaymentStatus_void()
    // {

    // }

    // [TestMethod]
    // public void SetFulfilled_SetsBoolOfOrderFulfilledStatus_void()
    // {

    // }