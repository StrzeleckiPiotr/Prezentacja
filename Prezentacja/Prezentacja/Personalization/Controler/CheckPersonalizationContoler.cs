using prezentacja.DtoModel;
using prezentacja.Personalization.Controler;
using prezentacja.Personalization.Model;
using System;


namespace prezentacja
{
  public class CheckPersonalizationContoler
  {
    public static void CheckMatch()
    {
      PersonalizationControler personalizationControler = new PersonalizationControler();
      ClientDetails clientDetails = personalizationControler.FindClientDetails();
      DtoHome dtoHome = new DtoHome();
      bool isCalculateMatch = CalculateControler.CalculateMatch(clientDetails, dtoHome);

      Console.WriteLine(isCalculateMatch.ToString());

    }
  }
}
