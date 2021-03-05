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

    
  }
}