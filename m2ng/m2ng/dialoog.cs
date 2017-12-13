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
            Ekraan.Sonum("mina", "Eee..Jah, kes see on?");
            Ekraan.Sonum("Helistaja", "Tervist, mina olen Tatjana, helistan Ruthle psühiaatrikliinikust, Dell'i linnast, teie kaksikuga seoses.");
            Ekraan.Sonum("Helistaja", "Nimelt on teie kaksikul, Alex Lee Epp'il avastatud eluohtlik haigus, mille ostmiseks meil õigust ja rahalist toetust ei ole.");
            //Console.WriteLine("*Helistaja* : ");
            //Console.WriteLine("*Helistaja* : ");
            Console.WriteLine("*Helistaja* : Kuna tal ei ole luba välja ning endal sissetulekut ei ole, siis ei saa ta rohtu soetada, " +
                "seega me palume teil talle need rohud välja osta.");
            Console.WriteLine("     [MINA] : Rohud.. Psühiaatrikliinik.. Mida? Millal ta sinna sattus? Ahah, " +
                "*kirjutan* Dell'is.., Ruthle kliinik jah? *lõpetan kirjutamise* Selge, lendan täna sinna.");
            Console.WriteLine("*Helistaja* : Aitäh teile.");
        }

        public static void Dialo()
        {
            var kysimus = "";
            var kasutaja = new karakter();

            //Console.WriteLine("\nTere tulemast '24 tundi'.\n\n");
            Ekraan.Tervitus();

            do
            {
                Console.WriteLine("Palun valige oma karakterile nimi (min. 5 tähte).");
                kysimus = Console.ReadLine();
            } while (kysimus.Length < 5);
            kasutaja.nimi = kysimus;

            var vanus = 0;
            do
            {
                Console.WriteLine("Tere {0}. Sisestage palun oma vanus.", kasutaja.nimi);
                kysimus = Console.ReadLine();
            } while (!int.TryParse(kysimus, out vanus) || vanus < 16);
            kasutaja.vanus = vanus;
            Console.WriteLine("Rõõm tutvuda sinuga {0} aastane {1}.", kasutaja.vanus, kasutaja.nimi);
            do
            {
                Console.WriteLine("Mis soost te olete? ('naine' või 'mees')");
                kysimus = Console.ReadLine();
            } while (kysimus.ToLower() != "naine" && kysimus.ToLower() != "mees");

            kasutaja.sugu = kysimus.ToLower();

            Console.Clear();
            Ekraan.Tervitus();

            Console.WriteLine("*Ärkad telefoni helina peale. Vaatad kella, kell on 7:00, otusustad kõnet ignoreerida.*");
            Console.WriteLine("*Tõused üles, jõuad kööki, paned raadio mängima ning teed võileiba.*");
            Console.WriteLine("*Raadio*: Tere hommikust, kell on 07:03. Tõuse ja sära!");
            telk6n1: // VERY BAD PRACTICE!!!! DONT DO THIS!!!! NEVER!!!!  
            Console.WriteLine("*Telefon heliseb uuesti.* 'vasta' või 'ignoreeri'");
            string telk6n1 = Console.ReadLine();

            if (telk6n1 == "vasta")
            {
                Console.WriteLine("*Helistaja*: Tere, kas teie olete {0}?", kasutaja.nimi);
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
