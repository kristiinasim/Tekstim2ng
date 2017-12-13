using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class lennujaam
    {
        public static void Lennujaam()
        {
            Console.WriteLine("*Pakin kiiresti oma kohvri kokku ning sean sammud lennujaama poole.*");
            Console.WriteLine("*Uksel vaatan kella, kell on 7:36, unustan äärepealt rahakoti koju. Nüüd on kõik kaasas, minek.*");
            Console.WriteLine("-------------------");
            Console.ReadLine();
            Console.WriteLine("*Kell on 8:13, oleme lennukiga õhku tõusmas. Tunne on ärev, ei tea mida oodata. Ees ootab 4 tundi sõitu.");
            Console.ReadLine();
            Console.WriteLine("*Lõpuks lennukilt maas, lennujaamas, kell on 12:27, nüüd on vaja leida apteek, osta rohi ja minna kaksikule külla. Mis saab valesti minna?");
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("<<<'''Vajuta suvalist klahvi, et edasi minna!'''>>>");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
