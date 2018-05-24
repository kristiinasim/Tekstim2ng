using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace m2ng
{
    class Program
    {
        public static string path;
        static void Main(string[] args)
        {
            //////Mäng järjekorras--
            Karakter kasutaja = new Karakter();
            path = @"../../info/Invetory.txt";
            File.Delete(path);
            string tekst = " ";
            File.AppendAllText(path, tekst);

            Console.ForegroundColor = ConsoleColor.Yellow;
            string pilt = System.IO.File.ReadAllText(@"..\..\info\pilt.txt");
            Console.WriteLine(pilt);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEt mängus edasi liikuda, pead vajutama suvalist klahvi.");
            Console.WriteLine("(Välja arvatud siis, kui tuleb kirjutada vastus.)");
            Console.WriteLine("Mängu käigus on soovitatav koguda võimalikult palju staminat.");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            Dialoog.Dialo();
            Lennujaam.JooKohvi();
            Lennujaam.Lennujaamm();
            Linna.Linnas();
            Linna.Linn();
            Apteek.Apt();
            Pood.Poes();
            Apteek2.Tagasi();
            Hullumaja.Hullumajaa();
            Koobas.Kooba();
            Lopp.Loppp();
        }
    }
}





