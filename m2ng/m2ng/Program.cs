﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            //Ärkamisest telefonikõnele vastamiseni
            //dialoog.Dialo();
            //Telefonikõnest külani
            //lennujaam.Lennujaam();

            //Pood
            TextFile ascii = new TextFile (@"C: \Users\opilane\Documents\GitHub\Tekstim2ng\m2ng\m2ng\info\ascii.txt");
            Console.WriteLine(ascii.getText());
            //Apteek
            TextFile aptjek = new TextFile(@"C:\Users\opilane\Documents\GitHub\Tekstim2ng\m2ng\m2ng\info\aptjek.txt");
            Console.WriteLine(aptjek.getText());
            Console.ReadLine();

        }
    }
}
