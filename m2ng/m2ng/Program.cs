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
            ////ASCII
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //string pilt = System.IO.File.ReadAllText(@"../../../../pilt.txt");
            //Console.WriteLine(pilt);
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Et mängus edasi liikuda, pead vajutama suvalist klahvi.");
            //Console.WriteLine("Välja arvatud, kui tuleb kirjutada vastus.");
            //Console.ResetColor();
            //Console.ReadKey();
            //Console.Clear();

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
            ////Lennujaamas sees ning linnas:
            //linna.linnas();
            ////Linnas. Alates teisest karakterist.
            //linna.linn();
            ////Apteek
            //apteek.apt();

            ////Pood
            //TextFile ascii = new TextFile(@"C: \Users\opilane\Documents\GitHub\Tekstim2ng\m2ng\m2ng\info\ascii.txt");
            //Console.WriteLine(ascii.getText());
            ////Apteek ja rohud
            //TextFile aptjek = new TextFile(@"C:\Users\opilane\Documents\GitHub\Tekstim2ng\m2ng\m2ng\info\aptjek.txt");
            //Console.WriteLine(aptjek.getText());

            //Console.ReadLine();
            //KOOBAS
            Koobas.Kooba();
        }
    }
}

