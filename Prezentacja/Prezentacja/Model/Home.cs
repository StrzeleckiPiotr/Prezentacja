using prezentacja.Personalization.Model;
using System;

namespace prezentacja.Model
{
  public class Home
  {
    public String name { get; set; }
    public int m2 { get; set; }
    public String Typ { get; set; }
    public Location Localization { get; set; }
    public Double Value { get; set; }
    public int RoomCount { get; set; }
    bool hasbalcony { get; set; }
  }
}
