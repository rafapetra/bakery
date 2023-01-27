using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers 
{
  public class HomeController : Controller
  {
  
     public ActionResult Index()
    {
  
      return View();
    }
    }
  }