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
            
            //path = @"../../../Invetory.txt";
            //File.Delete(path);


            ////ASCII
            //string pilt = System.IO.File.ReadAllText(@"C:\Users\opilane\Documents\GitHub\Tekstim2ng\pilt.txt");
            //Console.WriteLine(pilt);

            ////Ärkamisest telefonikõnele vastamiseni
            //dialoog.Dialo();
            ////Telefonikõnest külani
            // lennujaam.Lennujaam();

            ////Lennujaamas sees ning linnas:
            //linna.linnas();
            ////Linnas. Alates teisest karakterist.
            //linnas.linn();
            ////Apteek
            //apteek.apt();

            ////Pood
            ////Console.WriteLine("PATH : {0}", Directory.GetCurrentDirectory());
            
            //TextFile ascii = new TextFile(@"..\..\info\ascii.txt");
            //Console.WriteLine(ascii.getText());
            ////Apteek ja rohud
            
            //TextFile aptjek = new TextFile(@"..\..\info\aptjek.txt");
            //Console.WriteLine(aptjek.getText());

            //Console.ReadLine();


            //raha
            Console.WriteLine("Hetke saldo : {0}", raha.Saldo());
            //kui soovid raha juurde lisada
            raha.Muuda(10.3F);

            Console.WriteLine("Hetke saldo : {0}", raha.Saldo());
            bool jaak = false;
            do
            {
                //kui soovid raha ära võtta
                jaak = raha.Muuda(-5.0F);
                Console.WriteLine("Veel on raha : {0}", raha.Saldo());


            } while (jaak);

            Console.ReadLine();
        }



    }
    }

