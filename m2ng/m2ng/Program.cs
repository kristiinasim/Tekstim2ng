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
<<<<<<< HEAD
            //////Mäng järjekorras--

=======
            // !Tagasi külas!

            //Mäng järjekorras--
>>>>>>> 2fbf1c37744e2e418653cef25dd7be43e48f09a8
            karakter kasutaja = new karakter();
            path = @"../../info/Invetory.txt";
            File.Delete(path);
            string tekst = " ";
            File.AppendAllText(path, tekst);
<<<<<<< HEAD
            
=======

>>>>>>> 2fbf1c37744e2e418653cef25dd7be43e48f09a8
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

<<<<<<< HEAD
           
=======
>>>>>>> 2fbf1c37744e2e418653cef25dd7be43e48f09a8
            dialoog.Dialo();
            lennujaam.JooKohvi();
            lennujaam.Lennujaam();
            linna.linnas();
            linna.linn();
            apteek.apt();
            pood.poes();
            apteek2.tagasi();
            Hullumaja.hullumaja();
            Koobas.Kooba();
            lopp.Lopp();
        }
    }
    
    }





