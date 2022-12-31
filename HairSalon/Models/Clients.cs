using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public string CliName { get; set; }
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public Stylist Stylist { get; set; }
  }
}