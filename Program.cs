using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde2
{
    class Program
    {
        static void Main(string[] args)
        {
                // Console.WriteLine("Hallo Welt!");
                // Datentypen: ganze Zahlen; Dezimalzahlen; Zeichenketten, Zeichen, Wahrheitswerte (Boolean)
                // ganze Zahlen:
                int ganzeZahlA = 68;
                int ganzeZahl8;
                ganzeZahl8 = 8;
                short kleineganzeZahl;
                long großeganzeZahl;

                int ganzeZahlC = ganzeZahlA % ganzeZahl8;
                Console.WriteLine(ganzeZahlC);

                // GleitkommaZahlen (DezimalZahlen)
                double gleitkommaZahlA = 1;
                double gleitkommaZahl8 = 3;
                decimal großegleitkommaZahl;

                Console.WriteLine(gleitkommaZahlA / gleitkommaZahl8);

                double gleitkommaZahlC = ganzeZahlC + gleitkommaZahlA;
                // int zu double -> kein Problem
                // double zu int -> braucht Eingereifen
                Console.WriteLine(ganzeZahlC);

                bool wahrheitswert = true;
                // später mehr

                // Zeichen und Zeichenketten
                char Zeichen = '&';
                string zeichenketteA = "Hallo ";
                string zeichenketteB = "Welt";

                Console.WriteLine(zeichenketteA + zeichenketteB);
            
    }


