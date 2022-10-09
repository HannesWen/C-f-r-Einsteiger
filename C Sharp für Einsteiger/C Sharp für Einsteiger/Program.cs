using C_Sharp_für_Einsteiger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_für_Einsteiger
{
    class Program
    {
        static void Main(string[] args)
        {
            //S:180 Nr. 1
            //Console.Write("Geben Sie bitte den Radikant ein: ");
            //double radikant = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ergebnis: " + Math.Sqrt(radikant));

            //Console.ReadKey();

            List<int> meineListe = new List<int>();
            meineListe.Add(5);
            meineListe.Add(12);
            meineListe.Add(92);
            meineListe.Add(7);

            Console.WriteLine("Welchen Wert möchten SIe hinzufügen? ");
            int wert = int.Parse(Console.ReadLine());
            Console.WriteLine("An welcher Position möchten Sie Ihn einfügen? ");
            int position = int.Parse(Console.ReadLine());
            if (position - 1 <= meineListe.Count & position > 0)
            {
                meineListe.Insert(position - 1, wert);
            }
            else
            {
                Console.WriteLine("Die angegebene Position ist nicht verfügbar.");
            }

            foreach (int inhalt in meineListe)
            {
                Console.WriteLine(inhalt);
            }
            Console.ReadKey();
        }
        
    }
}