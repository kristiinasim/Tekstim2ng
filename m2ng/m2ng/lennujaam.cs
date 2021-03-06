﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Lennujaam
    {
        /// <summary>
        /// Jõuad lennujaama.
        /// </summary>
        public static void Lennujaamm()
        {
            Console.WriteLine("*Pakin kiiresti oma kohvri kokku ning sean sammud lennujaama poole.*");
            Console.ReadKey();
            Console.WriteLine("*Uksel vaatan kella, kell on 7:36, unustan äärepealt rahakoti koju. Nüüd on kõik kaasas, minek.*");
            Console.ReadKey();
            Console.WriteLine("*Kell on 8:13, oleme lennukiga õhku tõusmas. Tunne on ärev, ei tea mida oodata. Ees ootab 4 tundi sõitu.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("*Lõpuks lennukilt maas, lennujaamas, kell on 12:27, nüüd on vaja leida apteek, osta rohi ja minna kaksikule külla. Mis saab valesti minna?");
            Console.ReadKey();
        }
        /// <summary>
        /// Valik, kas juua kohvi või ei.
        /// </summary>
        public static void JooKohvi()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Hetkene stamina: " + Karakter.Stamina);
            Console.ResetColor();
            while (true)
            {
                Console.WriteLine("Joo enne kodust lahkumist kohvi (+50 stamina)? 'jah' või 'ei'");
                string jookohvi = Console.ReadLine();
                if (jookohvi == "jah")
                {
                    Console.WriteLine("Jood kiiresti tassi kohvi ja saad juurde +50 staminat.");
                    Karakter.Stamina += 50;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Hetkene stamina: " + Karakter.Stamina);
                    Console.ResetColor();
                    break;
                }
                else if (jookohvi == "ei")
                {
                    Console.WriteLine("Jätad hommikuse kohvi joomata.");
                    break;
                }
                else
                {
                    continue;
                }

            }
        }
    }
}
