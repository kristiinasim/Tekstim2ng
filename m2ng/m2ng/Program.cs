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


            path = @"../../../Invetory.txt";
            File.Delete(path);

            //ASCII
            Console.ForegroundColor = ConsoleColor.Yellow;

            string pilt = System.IO.File.ReadAllText(@"..\..\info\pilt.txt");

           
            Console.WriteLine(pilt);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Et mängus edasi liikuda, pead vajutama suvalist klahvi.");
            Console.WriteLine("(Välja arvatud siis, kui tuleb kirjutada vastus.)");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            //Ärkamisest telefonikõnele vastamiseni
            dialoog.Dialo();
            //Telefonikõnest külani
            lennujaam.JooKohvi();
            lennujaam.Lennujaam();

            //// !LÄHEB APTEEKI!
            //// !OTSIB TÖÖD + RAHA
            //// !HULLUMAJA OSA!
            //// !KOOPA OSA!
            //// !Tagasi külas!
            //Lennujaamas sees ning linnas:
            linna.linnas();
            //Linnas. Alates teisest karakterist.
            linna.linn();
            //Apteek

            TextFile ascii = new TextFile(@"..\..\info\ascii.txt");
            Console.WriteLine(ascii.getText());
            //Apteek ja rohud
            TextFile aptjek = new TextFile(@"..\..\info\aptjek.txt");
            Console.WriteLine(aptjek.getText());
            Console.ReadLine();
            /////Apteek tekst
            apteek.apt();
            //Poes rotte püüdmas
            pood.poes();
            //Apteeki tagasi, enne hullumaja
            apteek2.tagasi();


            //Console.ReadLine();


            // !LÄHEB APTEEKI!
            // !OTSIB TÖÖD + RAHA
            // !HULLUMAJA OSA!
            // !KOOPA OSA!
            // !Tagasi külas!

            //Pood
            //Console.WriteLine("PATH : {0}", Directory.GetCurrentDirectory());


            //KOOBAS
            Koobas.Kooba();
        }
    }
    
    }





