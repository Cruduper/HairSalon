namespace HairSalon.Models
{
  public class Client
  {
    public string Name { get; set; }
    public string HairColor { get; set;}
    public int HairThickness { get; set; }
    public int HairLength { get; set; }
    public bool Curly { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }


    public virtual Stylist Stylist { get; set; }
  }
}







// namespace BestRestaurants.Models
// {
//   public class Restaurant
//   {
//     public string Name { get; set; }
//     public int PricePoint { get; set; }
//     public bool Vegan { get; set; }
//     public int RestaurantId { get; set; }
//     public int CuisineId { get; set; }

//     public virtual Cuisine Cuisine { get; set; }
//   }
// }