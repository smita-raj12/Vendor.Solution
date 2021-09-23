using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
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
      Vendor newVendor = new Vendor("test NameVendor","test DescripitonVendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "test description";
      Vendor newVendor = new Vendor(name,description);

      //Act
      string result1 = newVendor.Name;
      string result2 = newVendor.Description;
      //Assert
      Assert.AreEqual(name, result1);
      Assert.AreEqual(description, result2);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "test description";
      Vendor newVendor = new Vendor(name,description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name1 = "Test Vendor";
      string description1 = "test description";
      string name2 = "walmart";
      string description2 = "Groceries";
      Vendor newVendor1 = new Vendor(name1,description1);
      Vendor newVendor2 = new Vendor(name2,description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name1 = "Test Vendor";
      string description1 = "test description";
      string name2 = "walmart";
      string description2 = "Groceries";
      Vendor newVendor1 = new Vendor(name1,description1);
      Vendor newVendor2 = new Vendor(name2,description2);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title = "Order title";
      string description = "Order Description";
      string price = "Order price";
      string date = "Order date";
      Order newOrder = new Order(title,description,price,date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Test Vendor";
      string vdescription = "test description";
      Vendor newVendor = new Vendor(name,vdescription);
      
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}