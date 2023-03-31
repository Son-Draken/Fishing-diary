using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarRyby
{
    public class RybaRevirSeznam
    {

        //list k vyberu reviru
        public List<RybarskyRevir> RevirList { get; set; } 

        //vyber rybyho druhu pro dochazku
        public readonly List<string> druhyRybList = new List<string>() { "Kapr", "Lín", "Amur", "Plotice", "Parma", "Perlín", "Ostroretka", "Karas stříbrný", "Karas obecný",
            "Tloušť", "Jesen", "Proudník", "Cejn", "Cejnek", "Hrouzek", "Ježdík", "Ouklej", "Úhoř", "Sumec", "Sumeček americký","Štika", "Candát","Okoun" };


        //seznam nejcastejsich reviru v dochazce (moje preference)
        public RybaRevirSeznam()
        {
            RevirList = new List<RybarskyRevir>()
            {
             new RybarskyRevir("Berounka 1", 401001),
             new RybarskyRevir("Berounka 2", 401002),
             new RybarskyRevir("Vltava 5", 401017),
             new RybarskyRevir("Vltava 6", 401018),
             new RybarskyRevir("Vltava 7", 401019)
            };
        }
    }
}
