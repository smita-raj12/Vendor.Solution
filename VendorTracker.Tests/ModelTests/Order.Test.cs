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
    [TestMethod]
    public void SetProprites_SetProprites_String()
    {
      //Arrange
      string title = "Order title";
      string description = "Order Description";
      string price = "Order price";
      string date = "Order date";
      Order newOrder = new Order(title,description,price,date);

      //Act
      string updatedTitle = "Order for bread";
      string updatedDescription = "50 bread orders";
      string updatedPrice = "100";
      string updatedDate = "today";
      newOrder.Title = updatedTitle;
      newOrder.Description = updatedDescription;
      newOrder.Price = updatedPrice;
      newOrder.Date = updatedDate;
      
      string resultTitle = newOrder.Title;
      string resultDescription= newOrder.Description;
      string resultPrice = newOrder.Price;
      string resultDate = newOrder.Date;

      //Assert
      Assert.AreEqual(updatedTitle, resultTitle);
      Assert.AreEqual(updatedDescription, resultDescription);
      Assert.AreEqual(updatedPrice, resultPrice);
      Assert.AreEqual(updatedDate, resultDate);
    }

  }
}    