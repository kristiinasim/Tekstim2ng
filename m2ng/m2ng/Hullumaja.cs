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
        /// <summary>
        /// Jõuame looga hullumajani, kus patsient ootamatult käitub.
        /// </summary>
        public static void Hullumajaa()
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
            while (true)
            {
                Console.WriteLine("Kas alustad kaksikuga rääkimist või ootad kuni tema alustab? 'alustan' või 'ootan'");
                string vastus = Console.ReadLine();
                Console.Clear();
                if (vastus == "alustan")
                {
                    Console.WriteLine("*Mina*: Tsau! Kuidas sul siin läheb ? ");
                    break;
                }
                else if (vastus == "ootan")
                {
                    Console.WriteLine("*Ootan millal ta ise hakkab rääkima minuga.*");
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Kaksik lööb sind ootamatult oimetuks ning põgeneb toast. Toibud paari minuti pärast.");
            Console.ReadKey();
            Console.WriteLine("Medõde aitab su püsti ning arvatakse, et sa oled oma kaksik.");
            Console.ReadKey();
            Console.WriteLine("Küsid, et minna vetsu ning põgened kanalisatsiooni.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
