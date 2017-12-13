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
            Console.WriteLine("*Näen teel noort naist lapsega.* Kas: 'jalutan mööda' või 'küsin juhiseid'");
            var valik4 = Console.ReadLine();
            if (valik4 == "jalutan mööda")
            {
                Console.WriteLine("Ma arvan, et tal on muudki teha. Liigun edasi.");
                Console.WriteLine("Pagan! Ma ei mõista kohe üldse, kus ma olen! *Näen üht noort meest* Tema tundub ärimehe moodi! Tema oskab kindlasti seletada!");
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
            Console.WriteLine("*Mõne aja pärast:*Hmm, olen kõndinud nii paremale kui ka edasi, kuid maja pole näha. Ehk peaksin korra veel küsida proovima?");
            Console.WriteLine("Seal ongi üks nooruk. Kas 'kõnnin mööda' või 'küsin abi'?");
            string valik5 = Console.ReadLine();

            if (valik5 == "kõnnin mööda")
            {
                Console.WriteLine("Ta tundub liiga noor, et täpset seletust anda. Küsin parem kõrvalolevalt mehelt.");
                Console.WriteLine("Tere! Kas te oskate mind Lare'i apteeki juhatada?");
                Console.WriteLine("*Mees:* Muidugi, see on ju otse siin nurga taga! Te peate lihtsalt ümber selle maja minema.");
                Console.WriteLine("Oh, kas tõesti!? Oh mind lolli! Aitäh.");
                Console.WriteLine("*Mees:* Pole hullu, head päeva!");
                Console.ReadLine();

            }
        
            else if (valik5 == "küsin abi")
            {
                Console.WriteLine("Tere. Kas sa oskaksid mind edasi juhatada? Soovin Lare'i apteeki minna.");
                Console.WriteLine("*Nooruk:* Jah, see on kohe siin nurga taga! Paljud turistid ei leia seda kohe üles.");
                Console.WriteLine("Oh, kas tõesti! Olen juba 15 minutit siin ringi käinud. Aitäh!");
                Console.ReadLine();
            }
            Console.WriteLine("*Peale pikka jalutuskäiku jõunagi lõpuks apteeki. Ma ei suuda uskuda, et seda varem üles ei leidnud, kuid mis siis ikka! Nüüd jääb üle vaid veel rohi osta.*");
            Console.WriteLine("__________________________________");
        }
    }
}