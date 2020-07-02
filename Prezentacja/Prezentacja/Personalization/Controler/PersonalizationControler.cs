using prezentacja.DtoModel;
using prezentacja.Personalization.Model;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;

namespace prezentacja.Personalization.Controler
{
  public class PersonalizationControler
  {
    private ClientDetails ClientDetails;
    public ClientDetails FindClientDetails()
    {
      ClientDetails = new ClientDetails
      {
        ID = new System.Guid()
      };

      ClientPreferanceScore clientPreferanceScore = new ClientPreferanceScore();
      LocationControler locationControler  = new LocationControler();
      locationControler.ShowLocation();
      clientPreferanceScore.UserInputData = new UserInputData();
      clientPreferanceScore.UserInputData.Location = locationControler.FindLocation();
      clientPreferanceScore.UserInputData.DtoHome = new DtoHome();
      clientPreferanceScore.Param1 = 1;
      clientPreferanceScore.Param2 = 2;
      clientPreferanceScore.Param3 = 3;

      ClientDetails.ListClientPreferanceScore = new List<ClientPreferanceScore>();
      ClientDetails.ListClientPreferanceScore.Add(clientPreferanceScore);

      return this.ClientDetails;
    }
  }
}
