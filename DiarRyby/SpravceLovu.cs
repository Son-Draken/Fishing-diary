using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DiarRyby
{
    public class SpravceLovu
    {
        public ObservableCollection<Lov>Lovi { get; set; }

        public SpravceLovu()
        {
            Lovi = new ObservableCollection<Lov>();
        }

        //přidá zápis lovu do kolekce Lovi
        public void Pridej(string jmenoReviru,int cisloReviru, DateTime datum, string krmeni, string nastraha, string druhRyby, int pocetRyb, int delkaRyb)
        {
            if (jmenoReviru.Length < 3)
                throw new ArgumentException("1 je příliš krátké");
            if (krmeni.Length < 3)
                throw new ArgumentException("2 je příliš krátké");
            if (nastraha.Length < 3)
                throw new ArgumentException("3 je příliš krátké");
            if (druhRyby.Length < 3)
                throw new ArgumentException("3 je příliš krátké");
            if (cisloReviru < 3)
                throw new ArgumentException("3 je příliš krátké");
            Lov lov = new Lov(jmenoReviru, cisloReviru, datum, krmeni, nastraha, druhRyby, pocetRyb, delkaRyb);
            Lovi.Add(lov);
        } 
    }
}
