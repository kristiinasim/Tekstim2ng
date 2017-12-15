using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class karakter
    {
        public karakter()
        {
            HP = 100;
            EnemyHP = 40;
            raha = 0;
        }
        public string nimi { get; set; }

        public int vanus { get; set; }
        public string sugu { get; set; }
        public static int stamina { get; set; }
        public static int raha { get; set; }
        public static int HP { get; set; }
        public static int EnemyHP { get; set; }
        public static void Staminacheck()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hetkene stamina: " + karakter.stamina);
            Console.ResetColor();
        }


        public static void Rahacheck()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sul on raha: " + karakter.raha);
            Console.ResetColor();
        }

        public static void Poleraha()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sul ei ole piisavalt raha, et seda osta!");
            Console.ResetColor();
        }

        public static void Kaotasid()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            string mang = System.IO.File.ReadAllText(@"..\..\info\manglabi1.txt");
            Console.WriteLine(mang);
            Console.ReadKey();
        }

        public static void Voitsid()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;
            string mega = System.IO.File.ReadAllText(@"..\..\info\mega.txt");
            Console.WriteLine(mega);
            string tubli = System.IO.File.ReadAllText(@"..\..\info\tubli.txt");
            Console.WriteLine(tubli);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}