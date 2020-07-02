
using Geolocation;
using System;

namespace prezentacja.Personalization.Model
{
  public class Location
  {
    public Coordinate Origin { get; set; }

    public Coordinate Destination { get; set; }

    public Double Distance { get; set; }

    public int InputRange { get; set; }
  }
}
