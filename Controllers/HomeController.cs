using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Item car = new Item("Toyota", 10000 , 23000, "White");
      return View(car);
    }
  }
}