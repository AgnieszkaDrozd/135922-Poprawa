using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa135922
{
    class Kierownik: Osoba, INadgodziny
    {
        private int iloscPodwladnych;
        
        public override void ObliczPensje() // przesłonięcie metody
        {
            base.podstawa = podstawa + iloscPodwladnych * 7; 
        }
        public Kierownik (string imie, string nazwisko, int podstawa, int iloscPodwladnych) //konstruktor parametryczny
        {
            base.imie = imie;
            base.nazwisko = nazwisko;
            base.podstawa = podstawa;
            this.iloscPodwladnych = iloscPodwladnych;
        }
        public override string ToString() // przesłonięcie metody
        {
            return "Kierownik: " + imie + nazwisko + ", podstawa: " + podstawa + ", ilość podwładnych: " + iloscPodwladnych;
        }

        public override int DoliczNadgodziny()
        {
            base.DoliczNadgodziny() = DoliczNadgodziny() + nadgodziny * 25;
        }
      
    }
}
