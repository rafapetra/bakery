using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Treats.Controllers
{
  public class TreatsController : Controller
  {

     public ActionResult Index()
    {
  
      return View();
    }
    }
  }