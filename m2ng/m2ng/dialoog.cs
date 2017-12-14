using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class dialoog
    {
        
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
            Console.WriteLine("Rohud.. Psühiaatrikliinik.. Mida? Millal ta sinna sattus? Selge, lendan täna sinna.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*kõne lõpp*");
            Console.ResetColor();
            Console.ReadKey();
        }

        public static void Dialo()
        {

           // Console.ForegroundColor = ConsoleColor.Green;
           //// Console.WriteLine("Tere tulemast '24 tundi'. Palun valige oma karakterile nimi.");
           // Console.ResetColor();
            karakter kasutaja = new karakter();
           kasutaja.nimi = Console.ReadLine();
           // Console.ForegroundColor = ConsoleColor.Green;
           // //Console.WriteLine("Nüüd sisestage palun vanus.");
           // Console.ResetColor();
           // kasutaja.vanus = int.Parse(Console.ReadLine());
           // Console.ForegroundColor = ConsoleColor.Green;
           // //Console.WriteLine("Mis soost te olete? (Palun valige ainult 'naine' või 'mees'!)");
           // Console.ResetColor();
           kasutaja.sugu = Console.ReadLine();
            Console.Clear();

            var kysimus = "";

            Console.WriteLine("\nTere tulemast '24 tundi'.\n\n");

            do
            {
                Console.WriteLine("Palun valige oma karakterile nimi (min. 3 tähte).");
                kysimus = Console.ReadLine();
            } while (kysimus.Length < 3);
            kasutaja.nimi = kysimus;

            var vanus = 0;
            do
            {
                Console.WriteLine("Tere {0}. Sisestage palun oma vanus.", kasutaja.nimi);
                kysimus = Console.ReadLine();
            } while (!int.TryParse(kysimus, out vanus));
            kasutaja.vanus = vanus;
            Console.WriteLine("Rõõm tutvuda sinuga {0} aastane {1}.", kasutaja.vanus, kasutaja.nimi);
            do
            {
                Console.WriteLine("Mis soost te olete? ('naine' või 'mees')");
                kysimus = Console.ReadLine();
            } while (kysimus.ToLower() != "naine" && kysimus.ToLower() != "mees");

            kasutaja.sugu = kysimus.ToLower();

            Console.Clear();
            //Ekraan.Tervitus();

            Console.WriteLine("*Ärkad telefoni helina peale. Vaatad kella, kell on 7:00, otsustad kõnet ignoreerida.*");
            Console.ReadKey();
            Console.WriteLine("*Raadio*: Tere hommikust, kell on 07:03. Tõuse ja sära!");
            Console.ReadKey();
            telk6n1:  
            Console.WriteLine("*Telefon heliseb uuesti.* 'vasta' või 'ignoreeri'");
            string telk6n1 = Console.ReadLine();
            Console.Clear();

            if (telk6n1 == "vasta")
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*Helistaja*: Tere, kas teie olete " + kasutaja.nimi + "?");
                Console.ResetColor();
                dialoog.Dia();
            }
            else if (telk6n1 == "ignoreeri")
            {
                Console.WriteLine("*Ignoreerin kõne, istun laua taha ja kuulan raadiost tulevaid jõululaule.*");
                Console.ReadKey();
                telk6n2:
                Console.WriteLine("*Telefon heliseb uuesti, lähen närvi.* 'vasta' või 'viskan telefoni aknast välja'");
                string telk6n2 = Console.ReadLine();
                Console.Clear();
                if (telk6n2 == "vasta")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Helistaja*: Tere, kas teie olete " + kasutaja.nimi + "?");
                    Console.ResetColor();
                    dialoog.Dia();
                }
                else if (telk6n2 == "viskan telefoni aknast välja")
                {
                    Console.WriteLine("*Hakkan telefoni aknast välja viskama, kuid viimasel hetkel mõtlen ümber ning vastan kõnele.*");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Helistaja*: Tere, kas teie olete " + kasutaja.nimi + "?");
                    Console.ResetColor();
                    dialoog.Dia();
                }
                else
                    goto telk6n2;
            }
            else
                goto telk6n1;
        }
    }
}
