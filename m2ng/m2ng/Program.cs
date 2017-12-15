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


            // !Tagasi külas!

            //Mäng järjekorras--

            karakter kasutaja = new karakter();
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




            apteek.apt();
            pood.poes();
            apteek2.tagasi();
            Hullumaja.hullumaja();
            Koobas.Kooba();
            lopp.Lopp();
            dialoog.Dialo();
            lennujaam.JooKohvi();
            lennujaam.Lennujaam();
            linna.linnas();
            linna.linn();
        }
    }
    
    }





