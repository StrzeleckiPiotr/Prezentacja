using prezentacja.DtoModel;
using prezentacja.Personalization.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace prezentacja.Personalization.Controler
{
  public static class CalculateControler
  {

    public static Boolean CalculateMatch(ClientDetails clientDetails, DtoHome EnableHome)
    {

     if (clientDetails == null)
      { 
        return false; 
      }

      var match =  clientDetails.ListClientPreferanceScore.Where(x => x.UserInputData.DtoHome.Equals(EnableHome));

      return match.Any();
    }
  }
}
