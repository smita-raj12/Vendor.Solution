using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test1","test2","test3","test4");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetInputs_ReturnsInputs_String()
    {
      //Arrange
      string title = "Order title";
      string description = "Order Description";
      string price = "Order price";
      string date = "Order date";
      //Act
      Order newOrder = new Order(title,description,price,date);
      string resultTitle = newOrder.Title;
      string resultDescription= newOrder.Description;
      string resultPrice = newOrder.Price;
      string resultDate = newOrder.Date;
      //Assert
      Assert.AreEqual(title, resultTitle);
      Assert.AreEqual(description, resultDescription);
      Assert.AreEqual(price, resultPrice);
      Assert.AreEqual(date, resultDate);
    }
  }
}    