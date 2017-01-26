using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa135922
{
    class Pracownik: Osoba, INadgodziny
    {
        private int staz;

        public override void ObliczPensje() // przesłonięcie metody
        {
            base.podstawa = podstawa + staz * 100;
        }

        public Pracownik (string imie, string nazwisko, int podstawa, int staz) //konstruktor parametryczny
        {
            base.imie = imie;
            base.nazwisko = nazwisko;
            base.podstawa = podstawa;
            this.staz = staz;
        }

        public override string ToString() // przesłonięcie metody
        {
            return "Pracownik: " + imie + nazwisko + ", podstawa: " + podstawa + ", staz: " + staz;
        }

        public override int DoliczNadgodziny()
        {
            base.DoliczNadgodziny() = DoliczNadgodziny() + nadgodziny * 15;
        }
        
        
    }


}
