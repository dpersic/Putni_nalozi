using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAccessLayer.ViewModels;

namespace DataAccessLayer
{
    public class PutniNaloziRepository
    {
        public List<PutniNalozi> _putninalozi = new List<PutniNalozi>();
        public List<Zaposlenici> _zaposlenici = new List<Zaposlenici>();
        public List<PutniNaloziVM> _putniNaloziVM = new List<PutniNaloziVM>();

        public GradoviRepository gradoviRepository = new GradoviRepository();
        public TipoviPrijevozaRepository tipoviRepository = new TipoviPrijevozaRepository();
        public ZaposleniciRepository zaposleniciRepository = new ZaposleniciRepository();

        public PutniNaloziRepository()
        {
            _putninalozi = DohvatiPutneNaloge();
            _zaposlenici = DohvatiZaposlenike();
            _putniNaloziVM = PutniNalozi();
        }

        public List<PutniNaloziVM> PutniNalozi()
        {
            var grad = gradoviRepository.DohvatiGrad();
            var tip = tipoviRepository.DohvatiTipPrijevoza();
            var zaposlenik = zaposleniciRepository.DohvatiZaposlenike();
            var putninalog = _putninalozi.Select(p => new PutniNaloziVM
            {
                PrezimeZaposlenika = zaposlenik.Where(z => z.ID == p.Zaposlenik_ID).Select(z => z.Prezime).FirstOrDefault(),
                ImeZaposlenika = zaposlenik.Where(z => z.ID == p.Zaposlenik_ID).Select(z => z.Ime).FirstOrDefault(),
                VrstaPrijevoza = tip.Where(t => t.ID == p.Prijevoz_ID).Select(t => t.Naziv).FirstOrDefault(),
                GradPolaziste = grad.Where(g => g.ID == p.Polaziste_ID).Select(g => g.Naziv).FirstOrDefault(),
                GradOdrediste = grad.Where(g => g.ID == p.Odrediste_ID).Select(g => g.Naziv).FirstOrDefault(),
                DatumOdlaska = p.DatumOdlaska,
                DatumPovratka = p.DatumPovratka,
                Trajanje = IzracunavanjeTrajanjaVoznje(p.DatumOdlaska, p.DatumPovratka)
            }).ToList();
            return putninalog;
        }

        public  string IzracunavanjeTrajanjaVoznje(string DatumOdlaska, string DatumPovratka)
        {
            string Trajanje = "";
            if (DatumOdlaska == DatumPovratka)
            {
               Trajanje = "1 DAN";
            }
            else
            {
               Trajanje = "VIŠE DANA";
            }
        return Trajanje;

        }


        public List<PutniNalozi> DohvatiPutneNaloge()
        {
            List<PutniNalozi> putninalozi = new List<PutniNalozi>();

            StreamReader oSr = new StreamReader("C:/Users/Persic/Desktop/Putni_nalozi/WindowsFormPutniNalozi/DataAccessLayer/PutniNalozi.json");
            string sJson = "";
            using (oSr)
            {
                sJson = oSr.ReadToEnd();
            }
            JObject oJson = JObject.Parse(sJson);

            var oPutniNalozi = oJson["PutniNalozi"].ToList();

            for (int i = 0; i < oPutniNalozi.Count; i++)
            {
                putninalozi.Add(new PutniNalozi
                {
                    ID = (int)oPutniNalozi[i]["id"],
                    Zaposlenik_ID = (int)oPutniNalozi[i]["zaposlenik_id"],
                    Prijevoz_ID = (int)oPutniNalozi[i]["prijevoz_id"],
                    Polaziste_ID = (int)oPutniNalozi[i]["polaziste_id"],
                    Odrediste_ID = (int)oPutniNalozi[i]["odrediste_id"],
                    DatumOdlaska = (string)oPutniNalozi[i]["datum_odlaska"],
                    DatumPovratka = (string)oPutniNalozi[i]["datum_povratka"]
                });
            }
            return putninalozi;
        }
        //2.zadatak/////////////////////////////////////////////////////////////////////////////////////////
        public List<ZaposleniciVM> DajZaposlenike()
        {
            var zaposlenici = _zaposlenici.Select(z => new ZaposleniciVM
            {
                ID = z.ID,
                Ime = z.Ime,
                Prezime = z.Prezime,
                BrojPutnihNaloga = DajBrojPutnihNaloga(z.ID)
            }).ToList();
            return zaposlenici;
        }

        public int DajBrojPutnihNaloga(int nZaposlenikID)
        {
            int nBrojPutnihNaloga = 0;
            var putniNalozi = DohvatiPutneNaloge();
            var zaposlenici = DohvatiZaposlenike();

            for (int i = 0; i < putniNalozi.Count; i++)
            {
                for (int j = 0; j < zaposlenici.Count; j++)
                {
                    if (nZaposlenikID == putniNalozi[i].Zaposlenik_ID && nZaposlenikID == zaposlenici[j].ID)
                    {
                        nBrojPutnihNaloga++;
                    }
                }

            }
            return nBrojPutnihNaloga;
        }

        public List<Zaposlenici> DohvatiZaposlenike()
        {
            List<Zaposlenici> zaposlenici = new List<Zaposlenici>();

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
                zaposlenici.Add(new Zaposlenici
                {
                    ID = (int)oZaposlenici[i]["id"],
                    Ime = (string)oZaposlenici[i]["ime"],
                    Prezime = (string)oZaposlenici[i]["prezime"]
                });
            }
            return zaposlenici;
        }
        public PutniNaloziVM GetPutniNalogById(int zaposlenikId)
        {
            var grad = gradoviRepository.DohvatiGrad();
            var tip = tipoviRepository.DohvatiTipPrijevoza();
            var zaposlenik = DohvatiZaposlenike();

            var putninalog = _putninalozi.Where(p => p.Zaposlenik_ID == zaposlenikId).Select(p => new PutniNaloziVM
            {
                VrstaPrijevoza = tip.Where(t => t.ID == p.Prijevoz_ID).Select(t => t.Naziv).FirstOrDefault(),
                GradPolaziste = grad.Where(g => g.ID == p.Polaziste_ID).Select(g => g.Naziv).FirstOrDefault(),
                GradOdrediste = grad.Where(g => g.ID == p.Odrediste_ID).Select(g => g.Naziv).FirstOrDefault(),
                DatumOdlaska = p.DatumOdlaska,
                DatumPovratka = p.DatumPovratka,
                putniNaloziZaposlenika = DajPutneNalogeZaposlenika(zaposlenikId)
            }).FirstOrDefault();
            return putninalog;
        }

        public List<PutniNaloziVM> DajPutneNalogeZaposlenika(int zaposlenikID)
        {
            var grad = gradoviRepository.DohvatiGrad();
            var tip = tipoviRepository.DohvatiTipPrijevoza();
            var zaposlenik = DohvatiZaposlenike();

            var putniNalozi = _putninalozi.Where(p => p.Zaposlenik_ID == zaposlenikID).Select(p => new PutniNaloziVM
            {
                PrezimeZaposlenika = zaposlenik.Where(z => z.ID == p.Zaposlenik_ID).Select(z => z.Prezime).FirstOrDefault(),
                ImeZaposlenika = zaposlenik.Where(z => z.ID == p.Zaposlenik_ID).Select(z => z.Ime).FirstOrDefault(),
                VrstaPrijevoza = tip.Where(t => t.ID == p.Prijevoz_ID).Select(t => t.Naziv).FirstOrDefault(),
                GradPolaziste = grad.Where(g => g.ID == p.Polaziste_ID).Select(g => g.Naziv).FirstOrDefault(),
                GradOdrediste = grad.Where(g => g.ID == p.Odrediste_ID).Select(g => g.Naziv).FirstOrDefault(),
                DatumOdlaska = p.DatumOdlaska,
                DatumPovratka = p.DatumPovratka,
                Trajanje = IzracunavanjeTrajanjaVoznje(p.DatumOdlaska, p.DatumPovratka)
            }).ToList();
            return putniNalozi;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //3.ZADATAK

        public List<PutniNaloziVM> Filter(string ime, string prezime, string odrediste )
        {
            var zaposlenici = _putniNaloziVM.Where(p => true); //linija koda koja govori da ce se uvijek ispisat sve drzave svijeta ukoliko nijedan uvijet nije ispunjen

            if (odrediste != "All")
            {
                zaposlenici = _putniNaloziVM.Where(p => p.GradOdrediste == odrediste);
            }
            if (!string.IsNullOrEmpty(ime))
            {
                zaposlenici = _putniNaloziVM.Where(p => p.ImeZaposlenika == ime);
            }

            if (!string.IsNullOrEmpty(prezime))
            {
                zaposlenici = _putniNaloziVM.Where(p => p.PrezimeZaposlenika == prezime);
            }

            

            return zaposlenici.ToList();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //4.ZADATAK

        public List<string> DajOdrediste() // funkcija koja vraća listu stringova
        {
            var odrediste = _putniNaloziVM.Where(p => !string.IsNullOrEmpty(p.GradOdrediste)).Select(p => p.GradOdrediste).Distinct().OrderBy(p => p).ToList(); //DISTINCT->ZBOG TOGA DA NAM ISPIŠE JEDNOM EUROPA
            odrediste.Insert(0, "All");
            return odrediste;
        }
    }
}
