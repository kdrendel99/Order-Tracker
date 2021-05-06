using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Vendor starterVendor = new Vendor("Vendor One","");
      return View(starterVendor);
    }


  }
}