using System.Collections.Generic;


namespace HairSalon.Models
{
  public class Stylist
  {
    public string Specialty { get; set; }
    public int Price { get; set; }
    public int Age { get; set; }
    public int CuttingSpeed { get; set; }

    public virtual ICollection<Client> Clients { get; set; }

  }

  public Stylist()
  {
    this.Clients = new Hashset<Client>();
  }
}