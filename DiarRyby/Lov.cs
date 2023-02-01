using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarRyby
{
    public class Lov

    {  
       
        public string JmenoReviru { get; set; }
        public int CisloReviru { get; set; }

        public DateTime Datum { get; set; }
        public string Krmeni { get; set; }
        public string Nastraha { get; set; }

        public string DruhRyby { get; set; }
        public int PocetRyby { get; set; }
        public int DelkaRyby { get; set; }

        public Lov(string jmenoReviru, int cisloReviru, DateTime datum, string krmeni, string nastraha, string druhRyby, int pocetRyb, int delkaRyb)
        {
            JmenoReviru = jmenoReviru;
            CisloReviru = cisloReviru;
            Datum = datum;
            Krmeni = krmeni;
            Nastraha = nastraha;
            DruhRyby = druhRyby;
            PocetRyby = pocetRyb;
            DelkaRyby = delkaRyb;    
        }


        public override string ToString()
        {
            return Datum.ToShortDateString() + " ";
        }
    }
}
