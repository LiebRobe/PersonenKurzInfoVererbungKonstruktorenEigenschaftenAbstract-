using System;
using System.Collections.Generic;
using PersonenKurzInfo.Bibliothek;

using static System.Console;
using static PersonenKurzInfo.Bibliothek.Berechne;

namespace PersonenInfoVererbungKonstruktorenEigenschaftenAbstract
{
    class Program
    {
        /* Erstellen Sie für jede abgeleitete Klasse zumindest zwei Objekte und fügen Sie alle
     * einer Liste hinzu.
     * Geben Sie danach alle Personen der Liste mit der Methode AusgebenKurzInfo aus.
     * Ändern Sie das Alter aller Professoren auf 60 und entfernen Sie alle Studenten aus
     * der Liste.
     * Geben Sie danach alle Personen der Liste erneut mit der Methode AusgebenKurzInfo
     * aus.
     */
        static void Main(string[] args)
        {
            Student st1 = new Student("Harald", "Mayer", 33, 2017, "Informatik", Geschlecht.männlich);
            Student st2 = new Student("Maria", "Huber", 24, 2016, "Publizistik", Geschlecht.weiblich);
            Student st3 = new Student("Gloria", "Metzger", 22, 2015, "Soziologie", Geschlecht.weiblich);

            Professor pr1 = new Professor("Rudolf", "Rogl", 62, "Programmieren", Geschlecht.männlich);
            Professor pr2 = new Professor("Heino", "Bichler", 45, "Mathematik", Geschlecht.männlich);
            Professor pr3 = new Professor("Henriete", "Müller", 36, "Hauswirtschaftslehre", Geschlecht.weiblich);

            Dozent dz1 = new Dozent("Gerhard", "Hinterleitner", 35, "Ernährungslehre", Geschlecht.männlich);
            Dozent dz2 = new Dozent("Silvia", "Grötzl", 32, "Psychologie", Geschlecht.weiblich);
            Dozent dz3 = new Dozent("Hanelore", "Geiger", 43, "Deutsch", Geschlecht.weiblich);

            List<Person> people = new List<Person>
            {
                st1, st2, st3,
                pr1, pr2, pr3,
                dz1, dz2, dz3
            };
            foreach (var p in people)
            { Write( $" { ( p is Student ? "Student: ": p is Professor ? "Professor: " : p is Dozent ? "Dozent: " : "" ) }"); p.KurzInfoAusgeben();
                Write($"Geboren im Jahr: {Geburtsjahr(p)}{(p is Student ? " (Studiertzeit in Jahren: "+StudierZeit_in_Jahren((Student)p).ToString()+")"  : "")}" + Environment.NewLine); }

            //foreach(var p in people) { if (p is Professor) p.Alter = 60;}
            for(int i = people.Count - 1; i >= 0 ; i--)
            {
                if (people[i] is Professor)
                    people[i].Alter = 60;
                else if (people[i] is Student)
                    people.RemoveAt(i);
            }


            WriteLine();
            //people.ForEach(x => x.KurzInfoAusgeben());
            foreach(Person p in people)
            {
                Write($"{(p is Student ? "Student: " :  p is Professor  ? p.Sex == Geschlecht.weiblich ? "Professorin " : "Professor " :  p is Dozent ? p.Sex == Geschlecht.weiblich ? "Dozentin " : "Dozent " : "")}");
                p.KurzInfoAusgeben();
                Write(Environment.NewLine);

            }

        }
    }
}
    /* Übung: PersonenKurzInfo,Vererbung, Konstruktoren, Eigenschaften, abstract
     * -----------------------
     * 
     * Erstellen Sie in einer Konsolenapplikation "Vererbung_Uebung_PersonenKurzInfo" und
     * eine Klassenbibliothek "Vererbung_Uebung_PersonenKurzInfo.Bibliothek" mit folgenden
     * Klassen:
     */






    /*    Klasse Person mit
       *       - den automatisch implementierten Eigenschaften Vorname, Nachname und Alter
       *       - einem Konstruktor, der Werte für Vorname, Nachname und Alter übernehmen
       *         kann
       *       - einer abstrakten Methode AusgebenKurzInfo ohne Parameter und ohne
       *         Rückgabewert.
       *       - Überschreiben Sie die Methode ToString, so dass diese den Vornamen, den
       *         Nachnamen und das Alter einer Person zurückgibt, z.B.
       *            Hermann Reiter (23)
       */








    /*    Klasse Student mit
       *       - den automatisch implementierten Eigenschaften StudienbeginnJahr und
       *         Studienrichtung
       *       - einem Konstruktor, der Werte für Vorname, Nachname, Alter,
       *         StudienbeginnJahr und Studienrichtung übernehmen kann.
       *       - Diese Klasse muss die abstrakte Methode AusgebenKurzInfo implementieren, 
       *         sodass die Methode z.B. folgende Ausgabe macht:
       *            Hermann Reiter (23), studiert seit 2015 Maschinenbau
       *         Dabei soll die ToString-Methode der Basisklasse verwendet werden.
       */





    /*    Klasse Professor mit
       *       - der automatisch implementierten Eigenschaften Fach (string)
       *       - einem Konstruktor, der Werte für Vorname, Nachname, Alter und Fach
       *         übernehmen kann.
       *       - Diese Klasse muss die abstrakte Methode AusgebenKurzInfo implementieren,
       *         sodass die Methode z.B. folgende Ausgabe macht:
       *            Heinz Wagner (52), Professor für Informatik
       *         Dabei soll die ToString-Methode der Basisklasse verwendet werden.
       */









    /*    Klasse Dozent mit
       *       - der automatisch implementierten Eigenschaften Fakultaet (string)
       *       - einem Konstruktor, der Werte für Vorname, Nachname, Alter und Fakultaet
       *         übernehmen kann.
       *       - Diese Klasse muss die abstrakte Methode AusgebenKurzInfo implementieren, 
       *         sodass die Methode z.B. folgende Ausgabe macht:
       *            Gregor Schneider (49), Dozent an der Fakultät für Bauingenieurwesen
       *         Dabei soll die ToString-Methode der Basisklasse verwendet werden.
       */


   







