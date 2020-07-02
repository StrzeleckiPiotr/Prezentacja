using prezentacja.Personalization.Model;
using System;

namespace prezentacja.DtoModel
{
  public class DtoHome
  {
    public String name { get; set; }
    public int Meter { get; set; }
    public String Typ { get; set; }
    public Location Localization { get; set; }
    public Double Value { get; set; }
    public int RoomCount { get; set; }
    bool hasbalcony { get; set; }
  }
}
