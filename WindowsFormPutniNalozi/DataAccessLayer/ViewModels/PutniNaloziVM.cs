using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ViewModels
{
    public class PutniNaloziVM
    {
        public string PrezimeZaposlenika { get; set; }
        public string ImeZaposlenika { get; set; }
        public string VrstaPrijevoza { get; set; }
        public string GradPolaziste { get; set; }
        public string GradOdrediste { get; set; }
        public string DatumOdlaska { get; set; }
        public string DatumPovratka { get; set; }
        public string Trajanje { get; set; }
        public List<PutniNaloziVM> putniNaloziZaposlenika { get; set; }
    }
}
