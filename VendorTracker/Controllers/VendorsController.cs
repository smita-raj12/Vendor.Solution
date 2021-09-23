using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newvendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedvendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedvendor.Orders;
      model.Add("vendor", selectedvendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundvendor = Vendor.Find(vendorId);
      Order newOrder = new Order(OrderDescription);
      foundvendor.AddItem(newOrder);
      List<Order> vendorOrders = foundvendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundvendor);
      return View("Show", model);
    }

  }
}