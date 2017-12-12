using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{ //Alates teisest linlasest
    class linnas
    {
        public static void linn()
        {
            Console.WriteLine("Näen teel noort naist lapsega. Kas: 'jalutan mööda' või 'küsin juhiseid'");
            var valik4 = Console.ReadLine();
            if (valik4 == "jalutan mööda")
            {
                Console.WriteLine("Ma arvan, et tal on muudki teha. Liigun edasi.");
                Console.WriteLine("Pagan! Ma ei mõista kohe üldse, kus ma olen! *Näen üht noort meest* Tema tundub ärimees! Tema oskab kindlasti seletada!");
                Console.WriteLine("Tere! Kas te oskate mind Lare'i apteeki juhatada?");
                Console.WriteLine("*Mees:* Muidugi! Te peate lihtsalt kõndima siit paremale ja siis 4 kilomeetrit edasi. Siis näete suurt maja - see ongi apteek!");
                Console.WriteLine("Suur tänu!");
                Console.WriteLine("_________________________________");




            }
            if (valik4 == "küsin juhiseid")
            {
                Console.WriteLine("Tere! Kas oskate mind palun Lare'i apteeki juhatada?");
                Console.WriteLine("*Naine:* Jah, sa pead siit minema paremale ja kõndima siis umbes 5 kilomeetrit otse edasi. Siis peaksidki märkama suurt maja, see ongi apteek.");
                Console.WriteLine("Aitäh!");

            }
        }
    }
}