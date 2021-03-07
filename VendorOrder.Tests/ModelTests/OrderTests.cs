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
      Order testOrder = new Order("Bread",10,0);

      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetType_ReturnsTypeOfOrder_string()
    {
      Order testOrder = new Order("Bread",10,0);
      string expectedType = "Bread";

      string returnedType = testOrder.Type;

      Assert.AreEqual(expectedType, returnedType);
    }

    [TestMethod]
    public void GetId_ReturnsIdOfOrder_int()
    {
      Order testOrder = new Order("Bread",10,0);
      int expectedId = 1;

      int returnedId = testOrder.Id;

      Assert.AreEqual(expectedId,returnedId);
    }

    [TestMethod]
    public void GetAmount_ReturnsAmountofOrder_int()
    {
      Order testOrder = new Order("Bread",10,0);
      int expectedAmount = 10;

      int returnedAmount = testOrder.Amount;

      Assert.AreEqual(expectedAmount, returnedAmount);
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