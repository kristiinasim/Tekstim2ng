using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Hullumaja
    {
        public static void hullumaja()
        {
            Console.WriteLine(" *Mina* : Tere. Ma tõin ravimid. Kas ma saaksin külastada oma kaksikut? ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.ReadKey();
            Console.WriteLine("*Doktor* : Jah. Medõde viib Teid tema ruumini. Õde! ");
            Console.ReadKey();
            Console.WriteLine("*Medõde* : Jah? ");
            Console.ReadKey();
            Console.WriteLine("*Doktor* : Viige ta Alex Lee Epp`i juurde palun.");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("*Liigume ruumi poole. Jõudnud sinna, laseb medõde su sisse.*");
            Console.ReadKey();
            Console.WriteLine("*Medõde paneb ukse kinni ning liigub tagasi oma kabinetti.*");
            Console.ReadKey();
            vastus:
            Console.WriteLine("Kas alustad kaksikuga rääkimist või ootad kuni tema alustab? 'alustan' või 'ootan'");
            string vastus = Console.ReadLine();
            if (vastus == "alustan")
            {
                Console.WriteLine("*Mina*: Tsau! Kuidas sul siin läheb ? ");
            }
            else if (vastus == "ootan")
            {
                Console.WriteLine("*Ootan millal ta ise hakkab rääkima minuga.*");
            }
            else goto vastus;
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*Kaksik lööb su toimetuks, vahetab sinu riided enda omade vastu ja põgeneb ruumist.*");
            Console.ReadKey();
            Console.WriteLine("Medõde siseneb ning aitab sind püsti. Viib su oma kabinetti, arvates, et sa oled oma kaksik Alex.");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("Ütled, et lähed WC-sse. Teel sinna leiad põgenemiseks tee kanalisatsiooni, mis on üllatavalt puhas.");
            Console.ReadKey();
        }
    }
}
