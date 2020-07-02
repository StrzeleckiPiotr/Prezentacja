using Newtonsoft.Json;
using prezentacja.Controler;
using prezentacja.DtoModel;
using prezentacja.Personalization.Controler;
using prezentacja.Personalization.Model;
using System;
using System.IO;
using System.Threading;

namespace prezentacja
{
  class Program
  {
    static void Main(string[] args)
    {
            var homeControler = new HomeControler();

            homeControler.ConvertToModelApartment();

            DtoHome dtoHome = homeControler.ConvertToModelDtoHome();

            string output = JsonConvert.SerializeObject(dtoHome);

            Console.WriteLine(output);

            string path = @"C:\Users\pstrz\Desktop\Przydatne_Smieci\PrezentacjaJson\json.json";

            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(output);
                tw.Close();
            }

        }

  }
}
