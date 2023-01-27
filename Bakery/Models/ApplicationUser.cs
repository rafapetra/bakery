using Microsoft.AspNetCore.Identity;

namespace Bakery.Models
{
    public class ApplicationUser : IdentityUser
    {
      public string Name { get; set; }
      public DateOnly Birthday { get; set; }
    }
}