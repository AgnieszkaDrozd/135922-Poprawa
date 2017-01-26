using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poprawa135922
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> Pracownicy = new List<Osoba>();
            Pracownicy.Add(new Pracownik("Andrzej", "Kowalski", 1200, 2));
            Pracownicy.Add(new Pracownik("Piotr", "Bbb", 1000, 1));
            Pracownicy.Add(new Kierownik("Łukasz", "Ccc", 3200, 10));
            Pracownicy.Add(new Pracownik("Karol", "Ddd", 900, 1));
            Pracownicy.Add(new Kierownik("Agata", "Eee", 1200, 8));
            Pracownicy.Add(new Pracownik("Karolina", "Fff", 1200, 2));
            Pracownicy.Add(new Pracownik("Jan", "Ggg", 1900, 6));
            Pracownicy.Add(new Pracownik("Igor", "Hhh", 822, 2));
            Pracownicy.Add(new Pracownik("Daniel", "Iii", 1123, 1));
            Pracownicy.Add(new Pracownik("Andrzej", "Jjj", 1876, 2));

            Console.WriteLine();
            foreach (Pracownik aPart in Pracownicy)
            {
                Console.WriteLine(aPart);
            }

        }
            
        
    }

   
}
