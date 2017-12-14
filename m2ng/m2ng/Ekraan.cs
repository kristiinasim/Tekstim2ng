using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Ekraan
    {
        public  static void Sonum(string kes, string sonum)
        {
            if (kes.ToLower() == "mina")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            } else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            Console.Write(" {0,10} ", kes);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" : ");
            Console.ResetColor();
            Console.WriteLine(sonum);
        }

        public static void Tervitus()
        {
            Console.WriteLine("Tere tulemast");
            Console.WriteLine("Te mängite mängu <24h>.");
            Console.WriteLine();
        }
    }
}
