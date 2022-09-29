using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_für_Einsteiger
{
    class Fahrrad
    {
        public string name;
        public int preis;
        public string kategorie;
        public int radgröße;
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




        }
    }
}
