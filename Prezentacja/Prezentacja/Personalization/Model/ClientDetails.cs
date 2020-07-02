using System;
using System.Collections.Generic;
using System.Text;

namespace prezentacja.Personalization.Model
{
  public class ClientDetails
  {
    public Guid ID { get; set; }

    public string FirstName { get; set; }

    public string SecondName { get; set; }

    public string City { get; set; }

    public String Addres { get; set; }

    public String ZipNumber { get; set; }

    public IList<ClientPreferanceScore> ListClientPreferanceScore { get; set; }

  }
}
