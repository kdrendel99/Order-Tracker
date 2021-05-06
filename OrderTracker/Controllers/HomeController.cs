using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      Vendor starterVendor = new Vendor("Vendor One","");
      return View(starterVendor);
    }

    [HttpGet("/vendors/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string name, string description)
    {
      Vendor myVendor = new Vendor(name, description);
      return View("Index", myVendor);
    }



  }
}