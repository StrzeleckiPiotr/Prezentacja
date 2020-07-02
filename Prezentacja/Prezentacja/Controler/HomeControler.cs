using prezentacja.Converter;
using prezentacja.DtoModel;
using prezentacja.Model;
using prezentacja.Personalization.Model;
using System;

namespace prezentacja.Controler
{
    public class HomeControler
  {
    public Apartment ConvertToModelApartment()
    {
      Home home = this.CreateHome();

      Apartment apartment = HomeToApartment.ConverToApartment(home);

      Console.WriteLine(home.GetType().ToString() + " " + home.name + " " + home.Localization + " " + home.m2 + " " + home.Typ);
      Console.WriteLine(apartment.GetType().ToString() + " " + apartment.name + " " + apartment.Localization + " " + apartment.m2 + " " + apartment.Typ);
      return apartment;
    }

    public DtoHome ConvertToModelDtoHome()
    {
      Home home = this.CreateHome();

      DtoHome dtoHome = HomeToDtoHome.ConvertToDtoHome(home);

      Console.WriteLine(home.GetType().ToString() + " " + home.name + " " + home.Localization + " " + home.m2 + " " + home.Typ);
      Console.WriteLine(dtoHome.GetType().ToString() + " " + dtoHome.name + " " + dtoHome.Localization + " " + dtoHome.Meter + " " + dtoHome.Typ);
      return dtoHome;
    }

    public Home CreateHome()
    {
      Home home = new Home();
      home.Localization = new Location();
      home.m2 = 50;
      home.name = "ładna";
      home.Typ = "nowe";

      return home;
    }
  }
}