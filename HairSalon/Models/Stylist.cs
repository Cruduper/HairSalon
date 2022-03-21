using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public string Name { get; set; }
    public string Specialty { get; set; }
    public int Price { get; set; }
    public string Experience { get; set; }
    public int CuttingSpeed { get; set; }
    public int StylistId { get; set; }

    public virtual ICollection<Client> Clients { get; set; }

    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
  }
}