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
    public class TipoviPrijevozaRepository
    {
        public List<TipoviPrijevoza> _tipoviprijevoza = new List<TipoviPrijevoza>();

        public List<TipoviPrijevoza> DohvatiTipPrijevoza()
        {
            StreamReader oSr = new StreamReader("C:/Users/Persic/Desktop/Putni_nalozi/WindowsFormPutniNalozi/putni.json");
            string sJson = "";
            using (oSr)
            {
                sJson = oSr.ReadToEnd();
            }
            JObject oJson = JObject.Parse(sJson);

            var oTipPrijevoza = oJson["TipoviPrijevoza"].ToList();

            for (int i = 0; i < oTipPrijevoza.Count; i++)
            {
                _tipoviprijevoza.Add(new TipoviPrijevoza
                {
                    ID = (int)oTipPrijevoza[i]["id"],
                    Naziv = (string)oTipPrijevoza[i]["naziv"]
                });
            }
            return _tipoviprijevoza;
        }
    }
}
