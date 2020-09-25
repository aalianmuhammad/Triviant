using System;
using System.Linq.Expressions;

namespace ConsoleTriviant
{
    class Program
    {
        static int score = 0; // aantal vragen goed
        static string Vraag = "Welke stad wordt ook wel sleutelstad genoemd?"; //vraag
        static string[] Antwoorden = { "Amsterdam", "Den Haag", "Rotterdam", "Leiden" }; // array met multiple choise
        static int JuisteAntwoord = 1; // index in array antwoorden van het JuisteAntwoord
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de quiz-vragen van Triviant.");
            Console.WriteLine("Je krijg nu vragen te zien op het scherm.");
            Console.WriteLine("Je ziet nu vier verschillende soorten antwoorden op het scherm.");
            Console.WriteLine("Kies het juiste antwoord op het scherm.");
            showVraag(1);
            showAntwoorden();
            try
            { 
                int Antwoord = int.Parse(Console.ReadLine());
                switch (checkAntwoord(Antwoord))
                {
                    case 1:
                        Console.WriteLine("goed gedaan");
                        score++;
                        break;
                    case 0:
                        Console.WriteLine("Dat is helaas niet goed. Het antwoord is " + Antwoorden[JuisteAntwoord]);
                        break;
                    case 99:
                        Console.WriteLine("Dit is geen gelidge invoer.");
                        break;
                }   
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void showVraag(int Nr)
        {
            Console.WriteLine("Vraag" + Nr + ":");
            Console.WriteLine(Vraag);
            Console.WriteLine("");
        }
        static void showAntwoorden()

        {
            int teller = 0;
            foreach (string antwoord in Antwoorden)
            {
                teller++;
                Console.WriteLine((teller) + ". " + Antwoorden);
            }
            Console.WriteLine("");
            Console.WriteLine("Selecteer uw keuze : 1,2,3, of 4");
        }

        static int checkAntwoord(int Antw)
        {
            if (Antw == JuisteAntwoord + 1)
            {
                return 1;
            }
            else if (Antw > 4)
            {
                return 99;
            }
            else
            {
                return 0;
            }
        }
    }
}
