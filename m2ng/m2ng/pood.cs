using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class pood:karakter
    {
        public static string path;
        public static void poes()
        {
            path = @"../../info/Invetory.txt";
            Console.WriteLine("Tere, poeomanik! Kuulsin, et teil on tööd pakkuda!");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*Poeomanik*: Oi jah, oi jah, mul oleks vaja rottidest lahti saada. Kas saaksid mind aidata?");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("Aga muidugi, kus nad on?");
            Console.ReadKey();
            Console.WriteLine("*Poeomanik juhatab mu keldrisse*");
            Console.ReadKey();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*Poe kelder on rotte täis. Kuidas nad tappa? Kas:");
                Console.WriteLine("'1': Löön labidaga pähe");
                Console.WriteLine("'2': Kasutan mürki");
                Console.WriteLine("'3': Uputan keldri üle");
                Console.ResetColor();
                var valik7 = Console.ReadLine();
                Console.Clear();
                if (valik7 == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tapsid rotid, kuid said neilt hammustada..");
                    Console.ReadKey();
                    Console.WriteLine("Rottide poolt tekitatud hammustus võttis sinult 5 HP maha.");
                    Console.ReadKey();
                    karakter.HP -= 5;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Järele jäänud HP on: " + karakter.HP);
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Poeomanik*: Oi aitäh, head inimesed siiski veel eksisteerivad! Siin on sulle 45 eurot tasuks.");
                    Console.ResetColor();
                    karakter.raha += 45;
                    break;
                }
                else if (valik7 == "2")
                {
                    Console.WriteLine("Tapsid rotid edukalt! Palju õnne!");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Poeomanik*: Oi aitäh, head inimesed siiski veel eksisteerivad! Siin on sulle 45 eurot tasuks.");
                    Console.ResetColor();
                    karakter.raha += 45;
                    break;
                }
                else if (valik7 == "3")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tapsid küll rotid, kuid kahjustasid veega poeomaniku varusid keldris.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Poeomanik*: Oi aitäh, head inimesed siiski veel eksisteerivad! Siin on sulle 45 eurot tasuks.");
                    Console.ReadKey();
                    Console.WriteLine("*Poeomanik*: Kuid kuna sa mu varusid kahjustasid siis võtan ma su tasust 10 eurot maha..");
                    Console.ResetColor();
                    karakter.raha += 35;
                    break;
                }

            }

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Sul on raha: " + karakter.raha);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.ReadKey();
            Console.WriteLine("*Poeomanik*: Kas soovid midagi osta? Meil on näiteks šokolaadi, vett, plaastreid ja muudki.");
            Console.ReadKey();
            Console.ResetColor();
            string ascii = System.IO.File.ReadAllText(@"..\..\info\ascii.txt");
            Console.WriteLine(ascii);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*Poeomanik*: Olen kuulnud, et toit taastab staminat..");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.ReadKey();
            Console.WriteLine("(Sul on vaja säilitada 20 eurot rohtude jaoks!)");
            Console.ResetColor();
            Console.ReadKey();
            var kasBreakin = false;
            while (true)
            {

            Console.WriteLine("'osta' või 'ei aitäh'");
            string osta = Console.ReadLine();
            Console.Clear();
            if (osta == "osta")
            {
                
                Console.WriteLine("*osta midagi neist:*");
                Console.WriteLine("'1': šokolaad - 4 eurot");
                Console.WriteLine("'2': pudel vett - 3 eurot");
                Console.WriteLine("'3': pakk küpsiseid - 6 eurot");
                Console.WriteLine("'4': paki plaastreid - 5 eurot");
                var valik8 = Console.ReadLine();
                Console.Clear();
                if (valik8 == "1")
                {
                    if (karakter.raha >= 4)
                    {
                        karakter.raha -= 4;
                        string tekst = "\nsokolaad";
                        File.AppendAllText(path, tekst);
                        Invetuur.Invcheck();
                        karakter.Rahacheck();
                    }
                    else if (karakter.raha < 4)
                        karakter.Poleraha();
                }
                else if (valik8 == "2")
                {
                    if (karakter.raha >= 3)
                    {
                        karakter.raha -= 3;
                        string tekst = "\nveepudel";
                        File.AppendAllText(path, tekst);
                        Invetuur.Invcheck();
                        karakter.Rahacheck();
                    }
                    else if (karakter.raha < 3)
                        karakter.Poleraha();
                }
                else if (valik8 == "3")
                {
                    if (karakter.raha >= 6)
                    {
                        karakter.raha -= 6;
                        string tekst = "\nkypsisepakk";
                        File.AppendAllText(path, tekst);
                        Invetuur.Invcheck();
                        karakter.Rahacheck();
                    }
                    else if (karakter.raha < 6)
                        karakter.Poleraha();
                }
                else if (valik8 == "4")
                {
                    if (karakter.raha >= 5)
                    {
                        karakter.raha -= 5;
                        string tekst = "\npakk plaastreid";
                        File.AppendAllText(path, tekst);
                        Invetuur.Invcheck();
                        karakter.Rahacheck();
                    }
                    else if (karakter.raha < 5)
                        karakter.Poleraha();
                }
                else continue;
                
                    while (true)
                    {

                        Console.WriteLine("Soovite veel osta? 'jah' või 'ei'");
                        string vastu = Console.ReadLine();
                        Console.Clear();
                        if (vastu == "jah")
                        {
                            if (karakter.raha >= 3)
                                break;
                            else if (karakter.raha < 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Sul ei ole piisavalt raha, et midagi osta!");
                                Console.ResetColor();
                            }
                        }
                        else if (vastu == "ei")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("*Poeomanik*: Aitäh teile, olite suureks abiks!");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.WriteLine("*Nüüd jääb üle vaid apteeki tagasi minna...*");
                            Console.ReadKey();
                            kasBreakin = true;
                            break;
                        }
                        else continue;
                    }
            }
                else if (kasBreakin == true)
                    break;
               
                else if (osta == "ei aitäh")
                {
                    Console.WriteLine("Ei aitäh, ma parem liigun edasi.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Poeomanik*: Aitäh teile, olite suureks abiks!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.WriteLine("*Sead sammud tagasi apteegi poole..*");
                    Console.ReadKey();
                    break;
                }
                else continue;
            }
        }
    }
}
