using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarRyby
{
    public class RybarskyRevir
    {
        public string NazevReviru { get; set; }
        public int CisloReviru { get; set; }

        public RybarskyRevir(string nazevReviru, int cisloReviru)
        {
            NazevReviru = nazevReviru;
            CisloReviru = cisloReviru;
        }

    }
}
