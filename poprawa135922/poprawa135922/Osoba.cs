using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa135922
{
    abstract class Osoba: IComparable<Osoba>
    {
        protected string imie;
        protected string nazwisko;
        protected int podstawa;
    
    }

    public Osoba()
    {

    }
    public virtual int ObliczPensje() //wirtualna metoda 
    {
        this.podstawa = podstawa;
    }

    public Osoba(string imie, string nazwisko, int podstawa) //konstruktor parametryczny
    {
        base.imie = imie;
    }
    public int CompareTo(Osoba other)
    {
 	    return this.nazwisko.CompareTo(other.nazwisko);
    }
}
