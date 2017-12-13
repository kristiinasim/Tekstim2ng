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
            //string pilt = System.IO.File.ReadAllText(@"C:\Users\opilane\Documents\GitHub\Tekstim2ng\pilt.txt");
            //Console.WriteLine(pilt);

            //Ärkamisest telefonikõnele vastamiseni
            dialoog.Dialo();
            //Telefonikõnest külani
            lennujaam.Lennujaam();
            //Lennujaamas sees ning linnas:
            linna.linnas();
            //Linnas. Alates teisest karakterist.
            linnas.linn();
            //Apteek
            apteek.apt();

            //Pood
            TextFile ascii = new TextFile(@"C: \Users\opilane\Documents\GitHub\Tekstim2ng\m2ng\m2ng\info\ascii.txt");
            Console.WriteLine(ascii.getText());
            //Apteek ja rohud
            TextFile aptjek = new TextFile(@"C:\Users\opilane\Documents\GitHub\Tekstim2ng\m2ng\m2ng\info\aptjek.txt");
            Console.WriteLine(aptjek.getText());

            Console.ReadLine();

            //KOOBAS
            Koobas.Kooba();
        }
    }
}

