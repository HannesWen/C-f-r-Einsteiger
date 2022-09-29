using C_Sharp_für_Einsteiger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_für_Einsteiger
{
    class Fahrrad
    {
        //S. 141 Nr. 1 
        //public int laufrad { get; set; }
        //public int rahmenhoehe { get; set; }
        //public string farbe { get; set; }
        //public string fahrradtyp { get; set; }
        //public void FahrradAusgeben()
        //{
        //    Console.WriteLine("Laufradgröße " + this.laufrad);
        //    Console.WriteLine("Rahmenhöhe " + this.rahmenhoehe);
        //    Console.WriteLine("Farbe " + this.farbe);
        //    Console.WriteLine("Fahrradtyp " + this.fahrradtyp);
        //}

        ////S. 141 Nr. 2 
        //public int laufrad { get; set; }
        //public int rahmenhoehe { get; set; }
        //public string farbe { get; set; }
        //public string fahrradtyp { get; set; }
        //public void FahrradAusgeben()
        //{
        //    Console.WriteLine("Laufradgröße " + this.laufrad);
        //    Console.WriteLine("Rahmenhöhe " + this.rahmenhoehe);
        //    Console.WriteLine("Farbe " + this.farbe);
        //    Console.WriteLine("Fahrradtyp " + this.fahrradtyp);
        //}
        //public void Laufrad(int laufrad)
        //{
        //    laufrad = laufrad;
        //}
        //public void Rahmenhoehe(int rahmenhoehe)
        //{
        //    rahmenhoehe = rahmenhoehe;
        //}
        //public void Farbe(string farbe)
        //{
        //    farbe = farbe;
        //}
        //public void Fahrradtyp(string fahrradtyp)
        //{
        //    fahrradtyp = fahrradtyp;
        //}

        ////S. 141 Nr. 3
        public int laufrad { get; set; }
        public int rahmenhoehe { get; set; }
        public string farbe { get; set; }
        public string fahrradtyp { get; set; }
        public void FahrradAusgeben()
        {
            Console.WriteLine("Laufradgröße " + this.laufrad);
            Console.WriteLine("Rahmenhöhe " + this.rahmenhoehe);
            Console.WriteLine("Farbe " + this.farbe);
            Console.WriteLine("Fahrradtyp " + this.fahrradtyp);
        }
        public void Laufrad(int laufrad)
        {
            this.laufrad = laufrad;
        }
        public void Rahmenhoehe(int rahmenhoehe)
        {
            this.rahmenhoehe = rahmenhoehe;
        }
        public void Farbe(string farbe)
        {
            this.farbe = farbe;
        }
        public void Fahrradtyp(string fahrradtyp)
        {
            this.fahrradtyp = fahrradtyp;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //S.106 Gebe die Quadratzahlen von 1-10 in einer while, do while und for schleife aus
            //int zahl = 1;
            //while (zahl <= 10)
            //{
            //    Console.WriteLine(zahl*zahl);
            //    zahl++;
            //}
            //for (zahl = 1; zahl <= 10; zahl++) 
            //{
            //    Console.WriteLine(zahl*zahl);
            //}
            //zahl = 1;
            //do
            //{
            //    Console.WriteLine(zahl*zahl);
            //    zahl++;
            //} while (zahl <= 10);
            //Console.ReadKey();

            //S.106 Namen abfragen und wenn benutzer fertig in liste speichern und in foreach schleife ausgeben
            //char weiter;
            //string name;
            //List<string> namenliste = new List<string>();
            //do
            //{
            //    Console.WriteLine("Bitte gebe mir einen Namen");
            //    name = Console.ReadLine();
            //    namenliste.Add(name);

            //    Console.WriteLine("Willst du einen weiteren namen hinzufügen? j/n");
            //    weiter = char.Parse(Console.ReadLine());
            //}while (weiter == 'j');
            //foreach (string inhalt in namenliste)
            //{
            //    Console.WriteLine(inhalt);
            //}
            //Console.ReadKey();

            //S.119 Nr 1. Klasse Fahrrad für Fahrradhändler erzeugen. Welche Eigenschaften ? Objekt erstellen und Werte eingeben -> ausgeben
            //Fahrrad fahrrad1 = new Fahrrad();
            //fahrrad1.name = "Kanban";
            //fahrrad1.preis = 750;
            //fahrrad1.kategorie = "Rennrad";
            //fahrrad1.radgröße = 26;
            //Console.WriteLine(fahrrad1.name);
            //Console.WriteLine(fahrrad1.preis);
            //Console.WriteLine(fahrrad1.kategorie);
            //Console.WriteLine(fahrrad1.radgröße);
            //Console.ReadKey();

            //S.119 Nr 2. Gleiche Aufgabe nur mit vorherhger abfrage
            //Fahrrad fahrrad1 = new Fahrrad();
            //Console.WriteLine("Bitte gebe die daten für dein Fahrrad nacheinander ein: Name, Preis, Kategorie, Radgröße");
            //fahrrad1.name = Console.ReadLine();
            //fahrrad1.preis = int.Parse(Console.ReadLine());
            //fahrrad1.kategorie = Console.ReadLine();
            //fahrrad1.radgröße = Convert.ToInt32(Console.ReadLine());
            //Console.Write(fahrrad1.name + fahrrad1.preis + fahrrad1.kategorie + fahrrad1.radgröße);
            //Console.ReadKey();



            //S. 138 Methoden verwenden C#
            //    class Haus
            //{
            //    public int grundflaeche;
            //    public int fensterzahl;
            //    public double hoehe;
            //    public string farbe;
            //    public string dachtyp
            //    public void MemberAusgeben()
            //    {
            //        Console.WriteLine("Grundfläche " + this.grundflaeche);
            //        Console.WriteLine("Fensterzahl " + this.fensterzahl);
            //        Console.WriteLine("Höhe " + this.hoehe);
            //        Console.WriteLine("Farbe " + this.farbe);
            //        Console.WriteLine("Dachtyp: " + this.dachtyp);
            //    }
            //    public void setGrundflaeche(int flaeche)
            //    {
            //        this.grundflaeche = flaeche;
            //    }
            //    public void setFensterzahl(int fenster)
            //    {
            //        this.fensterzahl = fenster;
            //    }
            //    public void setHoehe(double hoehe)
            //    {
            //        this.hoehe = hoehe;
            //    }
            //    public void setFarbe(string farbe)
            //    {
            //        this.farbe = farbe;
            //    }
            //    public void setDachtyp(string dachtyp)
            //    {
            //        this.dachtyp = dachtyp;
            //    }
            //    public double volumenBerechnen()
            //    {
            //        double volumen = this.grundflaeche * this.hoehe;
            //        if (this.dachtyp == "giebeldach")
            //        {
            //            volumen *= 0.75;
            //        }
            //        return volumen;
            //    }
            //}
            //Haus meinHaus = new Haus();
            //    meinHaus.setGrundflaeche(100);        
            //    meinHaus.setFensterzahl(12);       
            //    meinHaus.setHoehe(5.0);      
            //    meinHaus.setFarbe("weiß");      
            //    meinHaus.setDachtyp("Giebeldach");      
            //    meinHaus.MemberAusgeben();
            //    double volumenhaus = meinHaus.volumenBerechnen();     
            //    Console.WriteLine(volumenhaus);    
            //    Console.ReadKey();

            //S. 141 Nr. 1 
            //Fahrrad meinFahrrad = new Fahrrad();
            //Console.WriteLine("Geben Sie die Laufradgröße ein: ");
            //meinFahrrad.laufrad = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geben Sie die Rahmenhöhe ein: ");
            //meinFahrrad.rahmenhoehe = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geben Sie die Farbe ein: ");
            //meinFahrrad.farbe = Console.ReadLine();
            //Console.WriteLine("Geben Sie den Fahrradtyp ein: ");
            //meinFahrrad.fahrradtyp = Console.ReadLine();
            //meinFahrrad.FahrradAusgeben();
            //Console.ReadKey();

            //S. 141 Nr. 2
            //Fahrrad meinFahrrad = new Fahrrad();
            //Console.WriteLine("Geben Sie die Laufradgröße ein: ");
            //meinFahrrad.laufrad = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geben Sie die Rahmenhöhe ein: ");
            //meinFahrrad.rahmenhoehe = int.Parse(Console.ReadLine());
            //Console.WriteLine("Geben Sie die Farbe ein: ");
            //meinFahrrad.farbe = Console.ReadLine();
            //Console.WriteLine("Geben Sie den Fahrradtyp ein: ");
            //meinFahrrad.fahrradtyp = Console.ReadLine();
            //meinFahrrad.FahrradAusgeben();
            //Console.ReadKey();

            //S. 141 Nr. 3        
            List<Fahrrad> meineFahrräder = new List<Fahrrad>();
            char weiter = 'j';
            int zaehler = 0;
            while (weiter == 'j')
            {
                meineFahrräder.Add(new Fahrrad());
                Console.WriteLine("Geben Sie die Laufradgröße ein: ");
                meineFahrräder[zaehler].Laufrad(int.Parse(Console.ReadLine()));
                Console.WriteLine("Geben Sie die Rahmenhöhe ein: ");
                meineFahrräder[zaehler].Rahmenhoehe(int.Parse(Console.ReadLine()));
                Console.WriteLine("Geben Sie die Farbe ein: ");
                meineFahrräder[zaehler].Farbe(Console.ReadLine());
                Console.WriteLine("Geben Sie den Fahrradtyp ein: ");
                meineFahrräder[zaehler].Fahrradtyp(Console.ReadLine());
                zaehler++;
                Console.WriteLine("Möchtest du ein weiteres Fahrrad hinzufügen j/n ");
                weiter = char.Parse(Console.ReadLine()); 
            }
            foreach (Fahrrad f in meineFahrräder)
            {
                f.FahrradAusgeben();
            }
            Console.ReadKey();
        }
    }
}