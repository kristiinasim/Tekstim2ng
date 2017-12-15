using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class apteek2
    {
        public static string path;
        public static void tagasi()
        {
            path = @"../../info/Invetory.txt";
            Console.Clear();
            Console.WriteLine("*Apteeki sisenedes, kell seinal näitab nüüd 16:46:*");
            Console.ReadKey();
            Console.WriteLine("Tere, siin jälle mina! Tulin rohu eest maksma.");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*Apteeker*: See läheb siis jätkuvalt maksma 20 eurot.");
            Console.ReadKey();
            Console.ResetColor();
            karakter.Rahacheck();
            Console.ReadKey();
            if (karakter.raha >= 20)
            {
                karakter.raha -= 20;
                Console.WriteLine("Siin on raha. *ulatad raha apteekrile.*");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*Apteeker*: Palun, siin on teie rohi!");
                Console.ReadKey();
                Console.ResetColor();
                string tekst = "\nrohi 'Calvan'";
                File.AppendAllText(path, tekst);
                Invetuur.Invcheck();
            }
            else if (karakter.raha < 20)
            {
                Console.WriteLine("Teil ei ole piisavalt raha, et rohtu osta, seega on mäng läbi!");
                karakter.Kaotasid();
            }
            Console.ReadKey();
            Console.WriteLine("Aitäh! Kas oskate mulle öelda, kuhu jääb Ruhtle psühhiaatrikliinik?");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*Apteeker:* Oh, see on kohe siit üle tee ning vasakule!");
            Console.ReadKey();
            Console.ResetColor();
            valik9:
            Console.WriteLine("Kas 'tänan viisakalt' või 'jooksen välja'?");
            var valik9 = Console.ReadLine();
            Console.Clear();
            if (valik9 == "tänan viisakalt")
            {
                Console.WriteLine("Suur aitäh teile ja nägemist!");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*Apteeker:* Palun-palun, siin on sulle tee peale üks šokolaad, sul läheb energiat vaja!");
                Console.ReadKey();
                Console.ResetColor();
                string tekst = "\nsokolaad";
                File.AppendAllText(path, tekst);
                Invetuur.Invcheck();
                Console.WriteLine("Tänan, nägemist! *Lahkun.*");
            }
            else if (valik9 == "jooksen välja")
            {
                Console.WriteLine("*Torman uksest välja:* Nüüd tuleb kiirustada!");
            }
            else goto valik9;
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Juhiste järgi kõndides näengi suurt valget maja. Jah, see ongi psühhiaatrikliinik!");
            Console.ReadKey();
        }
    }
}
