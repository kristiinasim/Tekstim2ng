using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Hullumaja:karakter
    {
        public static void hullumaja()
        {
            Console.WriteLine(" *Mina* : Tere. Ma tõin ravimid. Kas ma saaksin külastada oma kaksikut? ");
            Console.WriteLine(" *Doktor* : Jah. Medõde viib Teid tema ruumini. Õde! ");
            Console.WriteLine(" *Medõde* : Jah? ");
            Console.WriteLine(" *Doktor* : Viige " + "Alex Lee Epp`i juurde palun.");
            Console.WriteLine(" -------------------");
            Console.WriteLine("* Liigume ruumi poole. Palud, et sind lastakse sisse.Pika anumise peale laseb medõde sind sisse,/n/ paneb ukse kinni ning ise seisab ukse kõrval väljaspol. * ");
            Console.WriteLine(" *Kas alustad rääkimist või ootad kuni tema alustab? ´alustan´/´ootan´");
            string vastus = Console.ReadLine();
            if (vastus == "alustan")
            {
                Console.WriteLine(" *Mina*: Tsau!Kuidas sul siin läheb ? ");
            }
            else if (vastus == "ootan")
            {
                Console.WriteLine("Ootan millal ta ise hakkab rääkima minuga.");
            }

            Console.WriteLine(" *Kaksik lööb su toimetuks, vahetab sinu riided enda omade vastu ja põgeneb hullumajast. Toibud juba 5 minuti pärast.");
            Console.WriteLine("  Medõde siseneb ning aitab sind püsti. Viib su oma kabinetti. Ütled, et lähed WC-sse ja kanalisatsiooni kaudu saad välja ning sul tuleb elueest joosta.* ");
        }
    }
}
