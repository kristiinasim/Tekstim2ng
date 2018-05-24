using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Karakter
    {
        /// <summary>
        /// Loob karakteri statistika.
        /// </summary>
        public Karakter()
        {
            HP = 100;
            EnemyHP = 40;
            Raha = 0;
        }
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; }
        public static int Stamina { get; set; }
        public static int Raha { get; set; }
        public static int HP { get; set; }
        public static int EnemyHP { get; set; }
        /// <summary>
        /// Näitab karakteri hetkest staminat.
        /// </summary>
        public static void Staminacheck()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hetkene stamina: " + Karakter.Stamina);
            Console.ResetColor();
        }
        /// <summary>
        /// Näitab raha summat.
        /// </summary>
        public static void Rahacheck()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sul on raha: " + Karakter.Raha);
            Console.ResetColor();
        }
        /// <summary>
        /// Raha puudub millegi ostmiseks.
        /// </summary>
        public static void Poleraha()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sul ei ole piisavalt raha, et seda osta!");
            Console.ResetColor();
        }
        /// <summary>
        /// Kaotasid mängu.
        /// </summary>
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
        /// <summary>
        /// Võitsid mängu.
        /// </summary>
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