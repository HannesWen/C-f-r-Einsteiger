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
            Auto meinAuto = new Auto(320, 23, 220);
            Geländewagen meingeländewagen = new Geländewagen(400, 42, 85, true);

            Console.WriteLine("Aktuelle GEschwindigkeit des Autos: " + meinAuto.getGeschwindigkeit());
            meinAuto.setGeschwindigkeit(200);
            Console.WriteLine("Neue Geschwindigkeit des Autos: " + meinAuto.getGeschwindigkeit());

            Console.WriteLine("Aktuelle Geschwindigkeit des Geländewagens: " + meingeländewagen.getGeschwindigkeit());
            Console.WriteLine("Allradantrieb vorhanden: " + meingeländewagen.getAllradantrieb());

            Console.ReadKey();
        }
    }
}