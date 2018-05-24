using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Dialoog
    {
        /// <summary>
        /// Sissejuhatus mängu.
        /// </summary>
        public static void Dia()
        {

            Console.WriteLine("Eee..Jah, kes see on?");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*Helistaja*: Tervist, mina olen Tatjana, helistan Ruthle psühiaatrikliinikust, Dell'i linnast, teie kaksikuga seoses.");
            Console.WriteLine("*Helistaja*: Nimelt on teie kaksikul, Alex Lee Epp'il avastatud eluohtlik haigus, mille ostmiseks meil õigust ja rahalist toetust ei ole.");
            Console.WriteLine("*Helistaja*: Kuna tal endal sissetulekut ei ole, siis ei saa ta rohtu soetada, seega me palume teil talle need rohud välja osta.");
            Console.ReadKey();
            Console.ResetColor();
            Console.WriteLine("Rohud.. Psühhiaatrikliinik.. Mida? Millal ta sinna sattus? Selge, lendan täna sinna.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*kõne lõpp*");
            Console.ResetColor();
            Console.ReadKey();
        }
        /// <summary>
        /// Karakteri nime, vanuse ja soo määramine ning mängu sissejuhatuse algus.
        /// </summary>
        public static void Dialo()
        {
            Karakter kasutaja = new Karakter();

            var kysimus = "";
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Palun valige oma karakterile nimi (min. 3 tähte).");
                Console.ResetColor();
                kysimus = Console.ReadLine();
            } while (kysimus.Length < 3);

            kasutaja.Nimi = kysimus;

            var vanus = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tere {0}. Sisestage palun oma vanus.", kasutaja.Nimi);
                Console.ResetColor();
                kysimus = Console.ReadLine();
            } while (!int.TryParse(kysimus, out vanus));
            kasutaja.Vanus = vanus;
            //Console.WriteLine("Rõõm tutvuda sinuga {0} aastane {1}.", kasutaja.vanus, kasutaja.nimi);
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mis soost te olete? ('naine' või 'mees')");
                Console.ResetColor();
                kysimus = Console.ReadLine();
            } while (kysimus.ToLower() != "naine" && kysimus.ToLower() != "mees");

            kasutaja.Sugu = kysimus.ToLower();

            Console.Clear();
            //Ekraan.Tervitus();

            Console.WriteLine("*Ärkad telefoni helina peale. Vaatad kella, kell on 7:00, otsustad kõnet ignoreerida.*");
            Console.ReadKey();
            Console.WriteLine("*Raadio*: Tere hommikust, kell on 07:03. Tõuse ja sära!");
            Console.ReadKey();
            while (true)
            {
                Console.WriteLine("*Telefon heliseb uuesti.* 'vasta' või 'ignoreeri'");
                string telk6n1 = Console.ReadLine();
                Console.Clear();
                if (telk6n1 == "vasta")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Helistaja*: Tere, kas teie olete " + kasutaja.Nimi + "?");
                    Console.ResetColor();
                    Dialoog.Dia();
                    break;
                }
                else if (telk6n1 == "ignoreeri")
                {
                    Console.WriteLine("*Ignoreerin kõne, istun laua taha ja kuulan raadiost tulevaid jõululaule.*");
                    Console.ReadKey();
                    while (true)
                    {
                        Console.WriteLine("*Telefon heliseb uuesti, lähen närvi.* 'vasta' või 'viskan telefoni aknast välja'");
                        string telk6n2 = Console.ReadLine();
                        Console.Clear();
                        if (telk6n2 == "vasta")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("*Helistaja*: Tere, kas teie olete " + kasutaja.Nimi + "?");
                            Console.ResetColor();
                            Dialoog.Dia();
                            break;
                        }
                        else if (telk6n2 == "viskan telefoni aknast välja")
                        {
                            Console.WriteLine("*Hakkan telefoni aknast välja viskama, kuid viimasel hetkel mõtlen ümber ning vastan kõnele.*");
                            Console.ReadKey();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("*Helistaja*: Tere, kas teie olete " + kasutaja.Nimi + "?");
                            Console.ResetColor();
                            Dialoog.Dia();
                            break;
                        }
                        else continue;
                    }
                    break;
                }
                else continue;
            }
        }
    }
}
