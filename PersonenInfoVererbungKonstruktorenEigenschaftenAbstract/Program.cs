using System;
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


   






}
