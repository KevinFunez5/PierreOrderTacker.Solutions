using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    { 
      return View();
    }

    // add additional paths with the format:
  
    // [Route("/pathName")]
    // public string PathName() 
    //  {
    //    add code here! add variables, use Models elements, etc.
    //    return "Always return something!"
    //  }
  }
}