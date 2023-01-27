using System.Collections.Generic;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
  }
}