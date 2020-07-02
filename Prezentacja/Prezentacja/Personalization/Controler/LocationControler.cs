using Geolocation;
using prezentacja.Personalization.Model;
using System;


namespace prezentacja.Personalization.Controler
{
  public class LocationControler
  {
    private readonly Location Location;

    public LocationControler()
    {
      Coordinate coordinate = new Coordinate();
      coordinate.Latitude = 34.076234;
      coordinate.Longitude = -118.395314;

      this.Location = new Location
      {
        Origin = coordinate
      };
    }

    public Location FindLocation()
    {
      return this.Location;
    }

    public void ShowLocation()
    {
      Console.WriteLine(this.Location.Origin.Latitude.ToString() + " " + this.Location.Origin.Longitude.ToString());
    }


  }
}

 


