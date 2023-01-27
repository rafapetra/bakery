using Microsoft.AspNetCore.Identity;
using System;

namespace Bakery.Models
{
    public class ApplicationUser : IdentityUser
    {
      public string Name { get; set; }
      public DateOnly Birthday { get; set; }
    }
}