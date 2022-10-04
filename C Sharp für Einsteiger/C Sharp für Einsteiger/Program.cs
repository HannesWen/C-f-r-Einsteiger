using C_Sharp_für_Einsteiger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_für_Einsteiger
{
    class Haus
    {
        private int grundflaeche;
        private int fensterzahl;
        private double hoehe;
        private string farbe;
        private string dachtyp;

        public Haus(int flaeche, int fenster, double hoehe, string farbe, string dach)
        {
            this.grundflaeche = flaeche;
            this.fensterzahl = fenster;
            this.hoehe = hoehe;
            this.farbe = farbe;
            this.dachtyp = dach;
        }
        public virtual void memberAusgeben()
        {
            Console.WriteLine("Grundfläche: " + this.grundflaeche);
            Console.WriteLine("Fensterzahl: " + this.fensterzahl);
            Console.WriteLine("Höhe: " + this.hoehe);
            Console.WriteLine("Farbe: " + this.farbe);
            Console.WriteLine("Dachtyp: " + this.dachtyp);
        }
        public void setFarbe(string farbe)
        {
            this.farbe = farbe;
        }
        public int getGrundflaeche()
        {
            return this.grundflaeche;
        }
        public int getFensterzahl()
        {
            return this.fensterzahl;
        }
        public double getHouehe()
        {
            return this.hoehe;
        }
        public string getFarbe()
        {
            return this.farbe;
        }
        public string getDachtyp()
        {
            return this.dachtyp;
        }
    }

   class Mehrfamilienhaus : Haus
    {
        private int anzahlWohnungen;

        public Mehrfamilienhaus(int flaeche, int fenster, double hoehe, string farbe, string dach, int wohnungen) :
            base(flaeche, fenster, hoehe, farbe, dach)
        {
            this.anzahlWohnungen = wohnungen;
        }

        public int getAnzahlWohnungnen()
        {
            return this.anzahlWohnungen;
        }
        public override void memberAusgeben()
        {
            base.memberAusgeben();
            Console.WriteLine("Anzahl Wohnungen: " + 
            this.anzahlWohnungen);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mehrfamilienhaus meinMehrfamilienhaus = new Mehrfamilienhaus(200, 20, 8.5, "beige", "Giebeldach", 6);
            Console.WriteLine(meinMehrfamilienhaus.getDachtyp());
            Console.WriteLine(meinMehrfamilienhaus.getAnzahlWohnungnen());
            meinMehrfamilienhaus.memberAusgeben();

            Console.ReadKey();
        }
    }
}