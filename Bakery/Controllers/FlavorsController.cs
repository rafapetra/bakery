using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bakery.Controllers
{
  public class FlavorsController : Controller
  {

     public ActionResult Index()
    {
  
      return View();
    }
    }
  }
