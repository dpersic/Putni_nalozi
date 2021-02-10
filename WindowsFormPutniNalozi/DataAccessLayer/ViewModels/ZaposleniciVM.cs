using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModels
{
    public class ZaposleniciVM
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int BrojPutnihNaloga { get; set;}
    }
}
