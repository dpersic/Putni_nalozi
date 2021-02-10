using DataAccessLayer.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GradoviRepository
    {
        public List<Gradovi> _gradovi = new List<Gradovi>();

        public List<Gradovi> DohvatiGrad()
        {
            StreamReader oSr = new StreamReader("C:/Users/Persic/Desktop/Putni_nalozi/WindowsFormPutniNalozi/putni.json");
            string sJson = "";
            using (oSr)
            {
                sJson = oSr.ReadToEnd();
            }
            JObject oJson = JObject.Parse(sJson);

            var oGrad = oJson["Gradovi"].ToList();

            for (int i = 0; i < oGrad.Count; i++)
            {
                _gradovi.Add(new Gradovi
                {
                    ID = (int)oGrad[i]["id"],
                    Naziv = (string)oGrad[i]["naziv"]
                });
            }
            return _gradovi;
        }
    }
}
