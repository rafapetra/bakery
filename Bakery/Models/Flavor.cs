using System.Collections.Generic;

namespace Bakery.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}