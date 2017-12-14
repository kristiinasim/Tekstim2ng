using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class pood
    {
        public static string path;
        public static void poes()
        {
            path = @"../../../Invetory.txt";
            Console.WriteLine("Tere, poeomanik! Kuulsin, et teil on tööd pakkuda!");
            Console.WriteLine("*Poeomanik:* Oi jah, oi jah, mul oleks vaja rottidest lahti saada. Kas saaksid mind aidata?");
            Console.WriteLine("Aga muidugi, kus nad on?");
            Console.WriteLine("*Poeomanik juhatab mu keldrisse*");
            Console.WriteLine("----------------");

            Console.WriteLine("*Poe kelder on rotte täis. Kuidas nad tappa? Kas:");
            Console.WriteLine("'1': Löön labidaga pähe");
            Console.WriteLine("'2': Kasutan mürki");
            Console.WriteLine("'3': Uputan keldri üle");

            var valik7 = Console.ReadLine();

            if (valik7 == "1")
            {
                Console.WriteLine("Tapsid rotid, kuid said neilt hammustada.");
                //MIINUS X STAMINA!
            }
            if (valik7 == "2")
            {
                Console.WriteLine("Tapsid rotid edukalt! Palju õnne!");
            }
            if (valik7 == "3")
            {
                Console.WriteLine("Tapsid küll rotid, kuid kahjustasid veega poeomaniku varusid keldris. Pead talle nüüd 5 eurot maksma.");
                //-5 EUROT!!!!!!!!!!
            }
            Console.WriteLine("-------");
            Console.WriteLine("*Poeomanik:* Oi aitäh, head inimesed siiski veel eksisteerivad! Siin on sulle 35 eurot tasuks.");
            //+35 EUROT!!!
            Console.WriteLine("*Poeomanik:* Kas soovid midagi osta? Meil on näiteks shokolaadi, vett, plaastreid ja muudki.");
            Console.WriteLine("*Kas soovid osta midagi neist:*");
            Console.WriteLine("'1': sokolaad - 3 eurot, + stamina");
            Console.WriteLine("'2': pudel vett - 2 eurot, + stamina");
            Console.WriteLine("'3': paki plaastreid - 4 eurot, +stamina");
            var valik8 = Console.ReadLine();

            if (valik8 == "1")
            {
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                string tekst = "\nsokolaad";
                File.AppendAllText(path, tekst);
                Invetuur.Inv();
                //LÕPETADA
            }
            if (valik8 == "2")
            {
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                string tekst = "\nveepudel";
                File.AppendAllText(path, tekst);
                Invetuur.Inv();

            }
             if (valik8 == "3")
            {
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                string tekst = "\npakk plaastreid";
                File.AppendAllText(path, tekst);
                Invetuur.Inv();
            }
            Console.WriteLine("Aitäh teile, olite suureks abiks!");
            Console.WriteLine("Nüüd jääb üle vaid apteeki tagasi minna...");
            Console.WriteLine("--------------");


           







        }
    }
}
