using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class KoobasFunc
    {
        /// <summary>
        /// Koopas tuleb vastu rott.
        /// </summary>
        public static void Rott()
        {
            ///
            Console.WriteLine("Näed koopas liikumas rotti.");
            Console.ReadKey();
            Console.WriteLine("Üritad rotti jälitada, kuid ta paneb plehku.");
            Console.ReadKey();
        }
        /// <summary>
        /// Koopas tuleb vastu rott, kes juhatab su välja.
        /// </summary>
        public static void RottValja()
        {
            Console.WriteLine("Näed koopas liikumas rotti. Ta laseb sul endale järgi jõuda.");
            Console.ReadKey();
            Console.WriteLine("Rotti jälitades leiad sa tee koopast välja!");
            Console.ReadKey();
        }
        /// <summary>
        /// Koopas on politsei, kelle eest õnnestub sul põgeneda.
        /// </summary>
        public static void PolitseiLucky()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Koopas on politsei!!");
            Console.ReadKey();
            Console.WriteLine("Õnnelik juhus, nad ei märganud sind!");
            Console.ReadKey();
            Console.ResetColor();
        }
        /// <summary>
        /// Koopas on politsei, kellega sa kokku jooksed.
        /// </summary>
        public static void Politsei()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Koopas on politsei ja ta nägi sind!");
            while (true)
            {
                Console.WriteLine("Sul on kaks valikut: 'jookse' või 'võitle'");
                Console.ResetColor();
                string Politsei = Console.ReadLine();
                if (Politsei == "jookse")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Otsustasid joosta.");
                    Console.ReadKey();
                    Console.WriteLine("Peidad ennast koopanurga pimeduses, politsei möödub sinust, sind mitte märgates.");
                    Console.ReadKey();
                    Console.WriteLine("Peidad ennast veel natukene aega igaks juhuks ning siis liigud edasi.");
                    Console.ResetColor();
                    break;
                }
                else if (Politsei == "võitle")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Hakkad liikuma politsei poole, et võidelda.");
                    Console.ReadKey();
                    Console.WriteLine("Politsei tõstab taskust relva, seda märgates otsustad sedamaid põgeneda.");
                    Console.ReadKey();
                    Console.WriteLine("Peidad ennast koopanurga pimeduses, politsei möödub sinust, sind mitte märgates.");
                    Console.ReadKey();
                    Console.WriteLine("Peidad ennast veel natukene aega igaks juhuks ning siis liigud edasi.");
                    Console.ResetColor();
                    break;
                }
                else continue;
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Kaotasid mängu.
        /// </summary>
        public static void MangLabi()
        {
            Console.WriteLine("Kaotasid mängu!");
            Karakter.Kaotasid();
            Environment.Exit(0);
        }
    }
}
