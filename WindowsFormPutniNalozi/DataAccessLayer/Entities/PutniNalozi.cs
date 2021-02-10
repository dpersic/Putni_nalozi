using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class PutniNalozi
    {
        public int ID { get; set; }
        public int Zaposlenik_ID { get; set; }
        public int Prijevoz_ID { get; set; }
        public int Polaziste_ID { get; set; }
        public int Odrediste_ID { get; set; }
        public string DatumOdlaska { get; set; }
        public string DatumPovratka { get; set; }
    }
}
