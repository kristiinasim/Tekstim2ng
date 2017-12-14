using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class apteek2
    {
        public static void tagasi()
        {
            Console.WriteLine("*Apteeki sisenedes, kell seinal näitab nüüd 16:46:*");
            Console.WriteLine("Tere, siin jälle mina! Tõin teile vajaliku rahasumma. *Ulatan raha poeomanikule*");
            //RAHA -20 EUROT
            Console.WriteLine("*Poeomanik:*Palun, siin on rohi. Edu teile!");
            Console.WriteLine("Aitäh! Kas oskate mulle öelda, kuhu jääb Ruhtle psühhiaatriakliinik?");
            Console.WriteLine("*Poeomanik:* Oh, see on kohe siit üle tee ning vasakule!");
            Console.WriteLine("Kas 'tänan viisakalt' või 'jooksen välja'?");
            var valik9 = Console.ReadLine();

            if (valik9 == "tänan viisakalt")
            {
                Console.WriteLine("Suur aitäh teile ja nägemist!");
                Console.WriteLine("*Poeomanik:* Palun-palun, siin on sulle tee peale üks shokolaad, sul läheb energiat vaja!");
                //+ 1 shokolaad
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                Invetuur.Inv();
                Console.WriteLine("Tänan, nägemist! *Lahkun.*");
            }
            if (valik9 == "jooksen välja")
            {
                Console.WriteLine("*Torman uksest välja:* Nüüd tuleb kiirustada!");
            }
            Console.WriteLine("Juhiste järgi kõndides näengi suurt valget maja. Jah, see ongi psühhiaatriakliinik!");
            Console.WriteLine("--------");

        }
    }
}
