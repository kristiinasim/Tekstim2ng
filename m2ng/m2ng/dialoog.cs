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
            Console.WriteLine("*Mina*: Eee..Jah, kes see on?");
            Console.WriteLine("*Helistaja*: Tervist, mina olen Tatjana, helistan Ruthle psühiaatrikliinikust, Dell'i linnast, teie kaksikuga seoses.");
            Console.ReadKey();
            Console.WriteLine("*Helistaja*: Nimelt on teie kaksikul, Alex Lee Epp'il avastatud eluohtlik haigus, mille ostmiseks meil õigust ja rahalist toetust ei ole.");
            Console.WriteLine("*Helistaja*: Kuna tal endal sissetulekut ei ole, siis ei saa ta rohtu soetada, seega me palume teil talle need rohud välja osta.");
            Console.WriteLine("*Mina*: Rohud.. Psühiaatrikliinik.. Mida? Millal ta sinna sattus? Selge, lendan täna sinna.");
            Console.WriteLine("*kõne lõpp*");
            Console.WriteLine("------------------");
            Console.ReadLine();
        }

        public static void Dialo()
        {
            Console.WriteLine("Tere tulemast '24 tundi'. Palun valige oma karakterile nimi.");
            karakter kasutaja = new karakter();
            kasutaja.nimi = Console.ReadLine();
            Console.WriteLine("Nüüd sisestage palun vanus.");
            kasutaja.vanus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis soost te olete? (Palun valige ainult 'naine' või 'mees'!");
            kasutaja.sugu = Console.ReadLine();

            Console.WriteLine("*Ärkad telefoni helina peale. Vaatad kella, kell on 7:00, otsustad kõnet ignoreerida.*");
            Console.WriteLine("*Raadio*: Tere hommikust, kell on 07:03. Tõuse ja sära!");
            telk6n1:
            Console.WriteLine("*Telefon heliseb uuesti.* 'vasta' või 'ignoreeri'");
            string telk6n1 = Console.ReadLine();

            if (telk6n1 == "vasta")
            {
                Console.WriteLine("*Helistaja*: Tere, kas teie olete " + kasutaja.nimi + "?");
                dialoog.Dia();
            }

            else if (telk6n1 == "ignoreeri")
            {
                Console.WriteLine("*Ignoreerin kõne, istun laua taha ja kuulan raadiost tulevaid jõululaule.*");
                telk6n2:
                Console.WriteLine("*Telefon heliseb uuesti, lähen närvi.* 'vasta' või 'viskan telefoni aknast välja'");
                string telk6n2 = Console.ReadLine();
                if (telk6n2 == "vasta")
                {
                    Console.WriteLine("*Helistaja*: Tere, kas teie olete " + kasutaja.nimi + "?");
                    dialoog.Dia();
                }

                else if (telk6n2 == "viskan telefoni aknast välja")
                {
                    Console.WriteLine("*Hakkan telefoni aknast välja viskama, kuid viimasel hetkel mõtlen ümber ning vastan kõnele.*");
                    Console.WriteLine("*Helistaja*: Tere, kas teie olete " + kasutaja.nimi + "?");
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
