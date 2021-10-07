using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new("Test Vendor");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
      Assert.AreEqual("Test Vendor", testVendor.Name);
      Assert.AreEqual(101, testVendor.Id);
      Assert.AreEqual(typeof(List<Order>), testVendor.Orders.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsAllInstancesOfVendor_VendorList()
    {
      Vendor.ClearAll();
      Vendor vendor1 = new("Vendor1");
      Vendor vendor2 = new("Vendor2");
      List<Vendor> expected = new List<Vendor>{vendor1, vendor2};
      CollectionAssert.AreEqual(expected, Vendor.GetAll());
    }

    [TestMethod]
    public void GetById_ReturnsVendorId_VendorList()
    {
      Vendor.ClearAll();
      Vendor vendor1 = new("Vendor1");
      Vendor vendor2 = new("Vendor2");
      Assert.AreEqual(vendor2, Vendor.GetbyId(2));
    }
  }
}