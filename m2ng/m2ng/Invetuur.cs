using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Invetuur
    {
        public static string path;
        public static string Inv()
        {
            using (StreamReader sr = new StreamReader("../../info/Invetory.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                return line;
            }
        }


        public static void Invcheck()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Sinu seljakotis on: ");
            Invetuur.Inv();
            Console.WriteLine("----------------------------");
            Console.ResetColor();
        }
    }
}
