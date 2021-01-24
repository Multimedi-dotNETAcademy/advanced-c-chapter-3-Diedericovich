using System;

namespace Klassen_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                * 
                * Digitale kluis
                * 
            Maak een klasse DigitaleKluis die we gaan gebruiken om een kluis voor te stellen.

            De klasse heeft volgende elementen:

            Een private variabele die de toegangscode van de kluis bewaard als geheel getal (naam: code)
            Een overloaded constructor die als parameter een geheel getal toelaat. 
            Dit getal zal worden toegewezen aan de private variabele code.
            Een full property CanShowCode die kan ingesteld worden op true or false, 
            om aan te geven of de code van buitenuit kan gezien worden.
            Een read-only property CodeLevel van type int. 
            Deze property zal het level van de code teruggeven. 
            Het level is eenvoudigweg de code gedeeld door 1000 als geheel getal 
            (dus indien de code 500 is zal 0 worden teruggegeven, 
            indien de code 2000 is wordt 2 teruggegeven, etc.)
            Een fullproperty Code met private set. 
            De get van deze property zal -666 teruggeven, tenzij CanShowcode op true staat, 
            in dit geval zal de effectieve code worden terug gegeven.
            Een methode TryCode die een geheel getal als parameter aanvaardt. 
            De methode geeft een true terug indien de code correct was, anders false. 
            Deze methode kan gebruikt worden om extern een code te testen , 
            indien deze overeenkomt met de bewaarde code dan zal gemeld worden dat 
            de code geldig is en wordt ook getoond hoeveel keer de gebruiker geprobeerd heeft. 
            Indien de gebruiker -666 meegaf dan meldt de methode dat de gebruiker een cheater is . 
            Indien de gebruiker een foute code meegaf dan meldt de methode dat dit een foute code was en
            wordt het aantal pogingen met 1 verhoogd.
            Een private variabele aantalpogingen om bij te houden hoe vaak de gebruiker geprobeerd heeft de code te vinden.
            Maak enkele Digitale Kluis objecten aan in je main en test of je bovenstaande klasse correct is geïmplementeerd.
                        */

            Kluis kluis = new Kluis(909);

            Console.WriteLine(kluis.CanShowCode);
            Console.WriteLine(kluis.CodeLevel);
            Console.WriteLine(kluis.Code);
            Console.WriteLine();
            Console.WriteLine(kluis.TryCode(100));
            Console.WriteLine(kluis.TryCode(-666));
            Console.WriteLine(kluis.TryCode(200));
            Console.WriteLine(kluis.TryCode(600));
            Console.WriteLine(kluis.TryCode(909));
            Console.WriteLine();
            Console.WriteLine(kluis.AantalPogingen);
            








        }
    }
}
