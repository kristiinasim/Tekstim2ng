﻿using System;
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
            Console.WriteLine("*Helistaja*: Tervist, mina olen Tatjana, helistan Ruthle hullumajast, Dell'i linnast, teie kaksikuga seoses.");
            Console.WriteLine("*Helistaja*: Nimelt on teie kaksikul, Alex Lee Epp'il lõpetatud rohtude toetamine ning ta ravikuur kestab veel 2 kuud.");
            Console.WriteLine("*Helistaja*: Kuna tal ei ole luba välja ning endal sissetulekut ei ole, siis ei saa ta rohtu soetada, seega me palume teil talle need rohud välja osta.");
            Console.WriteLine("*Mina*: Rohud.. Hullumaja.. Mida? Millal ta sinna sattus? Ahah, *kirjutan* Dell'is hullumajas, Ruthle hullumaja jah? *lõpetan kirjutamise* Selge, lendan täna sinna.");
            Console.WriteLine("*Helistaja*: Aitäh teile.");
        }

        public static void Dialo()
        {
            Console.WriteLine("Tere tulemast '24 tundi'. Palun valige oma karakterile nimi.");
            karakter kasutaja = new karakter();
            kasutaja.nimi = Console.ReadLine();
            Console.WriteLine("Nüüd sisestage palun vanus.");
            kasutaja.vanus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis soost te olete?");
            kasutaja.sugu = Console.ReadLine();

            Console.WriteLine("*Ärkad telefoni helina peale. Vaatad kella, kell on 7:00, otusustad kõnet ignoreerida.*");
            Console.WriteLine("*Tõused üles, jõuad kööki, paned raadio mängima ning teed võileiba.*");
            Console.WriteLine("*Raadio*: Tere hommikust, kell on 07:03. Tõuse ja sära!");
            telk6n1:
            Console.WriteLine("*Telefon heliseb uuesti.* 'vasta' või 'ignoreeri'");
            string telk6n1 = Console.ReadLine();
            if (telk6n1 == "vasta")
            {
                Console.WriteLine("*Helistaja*: Tere, kas ma räägin " + kasutaja.nimi + "-ga?");
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
                    Console.WriteLine("*Helistaja*: Tere, kas ma räägin " + kasutaja.nimi + "-ga?");
                    dialoog.Dia();
                }

                else if (telk6n2 == "viskan telefoni aknast välja")
                {
                    Console.WriteLine("*Hakkan telefoni aknast välja viskama, kuid viimasel hetkel mõtlen ümber ning vastan kõnele.*");
                    Console.WriteLine("*Helistaja*: Tere, kas ma räägin " + kasutaja.nimi + "-ga?");
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
