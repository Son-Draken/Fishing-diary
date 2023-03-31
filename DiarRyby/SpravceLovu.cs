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
        public void Pridej(string jmenoReviru,int cisloReviru, DateTime datum, string krmeni, string nastraha, string druhRyby, int pocetRyb, int delkaRyb, string ponechanaRyba)
        {
            if (jmenoReviru.Length < 3)
                throw new ArgumentException("Zápis revíru je příliš krátký");
            if (krmeni.Length < 3)
                throw new ArgumentException("Zápis krmení je příliš krátký");
            if (nastraha.Length < 3)
                throw new ArgumentException("Zápis nástraha je příliš krátký");
            if (druhRyby.Length < 3)
                throw new ArgumentException("Zápis druhu ryb je příliš krátký");
            if (cisloReviru < 3)
                throw new ArgumentException("Číslo revíru je příliš krátké");
            if (datum == null)
                throw new ArgumentException("Nezadal si datum");
            if (datum > DateTime.Today)
                throw new ArgumentException("Vidíš do budoucna, že víš co chytíš v následujících dnech?");
            Lov lov = new Lov(jmenoReviru, cisloReviru, datum, krmeni, nastraha, druhRyby, pocetRyb, delkaRyb, ponechanaRyba);
            Lovi.Add(lov);
        } 
    }
}
