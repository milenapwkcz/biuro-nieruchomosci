using System;

namespace Biuro_nieruchomosci
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba("anna", "Nowak", "02-03-1990", "00298290345", "Pro", "12", "ania@xd.pl", "881938902");
            Console.WriteLine(o1);
            Nieruchomosc n = new Nieruchomosc("m", "m", "d", 9, 3, 3, 3, 3, true, true, true, 3, Nieruchomosc.TypNieruchomosci.dom, Nieruchomosc.RodzajNieruchomosci.prawoWlasnoscioweBezKsiegi, Nieruchomosc.TypTransakcji.sprzedaz, Nieruchomosc.Standard.doOdswiezenia, Nieruchomosc.Rynek.pierwotny);
            WszystkieNieruchomosci razem = new WszystkieNieruchomosci();
            razem.DodajNieruchomosc(n);
            Console.WriteLine(razem);
            razem.UsunNieruchomosc("1/2020");
            Console.WriteLine(razem);
            
        }
    }
}
