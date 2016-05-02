using System;
using System.IO;
using System.Net;

namespace HalloGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ich weiß es ist nicht der Hammer, aber trotzdem:");
            Console.WriteLine("Hallo GitHub".ToUpper());

            Console.WriteLine();
            Console.WriteLine("Spannender wird es im GitHub-Projekt: LMStudent/hallo-octocat");

            Console.WriteLine();
            Console.WriteLine("Oder kannst du mir sagen in welcher Lektion des Udemy-Kurses");
            Console.WriteLine("'Einstieg in GitHub - professionelle Entwicklung im Team'");
            Console.WriteLine("dieses Projekt zu erst verwendet wird? Mit der richtigen Antwort ");
            Console.WriteLine("bekommst du noch ein wenig ASCII-Art von pi314 in deine Konsole!");
            Console.WriteLine("TIP: Schaue in der Kursbeschreibung oder im Quellcode nach ;-)");

            Console.WriteLine();
            Console.Write("Antwort: ");
            string antwort = Console.ReadLine();
            int antwortAlsZahl = 0;
            int.TryParse(antwort, out antwortAlsZahl);

            if (antwortAlsZahl == 42)
            {
                VerzaubereMitAsciiArt();
            }
            else
            {
                Console.WriteLine("Schade, dass war nicht die richtige Antwort.");
            }

            Console.ReadLine();
        }

        private static void VerzaubereMitAsciiArt()
        {
            var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/pi314/ascii-arts/master/octocat.asciiart");

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                var strContent = reader.ReadToEnd();
                Console.WriteLine(strContent);
            }

            Console.WriteLine();
            Console.WriteLine("ASCII-Art aus dem GitHub-Verzeichnis: pi314/ascii-arts");
        }
    }
}
