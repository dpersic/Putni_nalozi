using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.Entities;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DataAccessLayer
{
    public class ZaposleniciRepository
    {
        public List<Zaposlenici> _zaposlenici = new List<Zaposlenici>();

        public List<Zaposlenici> DohvatiZaposlenike()
        {
            StreamReader oSr = new StreamReader("C:/Users/Persic/Desktop/Putni_nalozi/WindowsFormPutniNalozi/putni.json");
            string sJson = "";
            using (oSr)
            {
                sJson = oSr.ReadToEnd();
            }
            JObject oJson = JObject.Parse(sJson);

            var oZaposlenici = oJson["Zaposlenici"].ToList();

            for (int i = 0; i < oZaposlenici.Count; i++)
            {
                _zaposlenici.Add(new Zaposlenici
                {
                    ID = (int)oZaposlenici[i]["id"],
                    Ime = (string)oZaposlenici[i]["ime"],
                    Prezime = (string)oZaposlenici[i]["prezime"]
                });
            }
            return _zaposlenici;
        } 
              
    }
}
