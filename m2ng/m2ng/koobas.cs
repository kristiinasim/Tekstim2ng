using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Koobas:karakter
    {
        public static string path;
        public static string StaPath;
        //9 toitu. 4 vett, 2 sokolaadi, 2 pakki kypsist, 1 coca cola
        public static void Vesi()
        {
            Ves:
            Console.WriteLine("Leiad maast veepudeli! 'korja üles' või 'jäta maha'");
            string Vesi = Console.ReadLine();
            if (Vesi == "korja üles")
            {
                string tekst = "\nveepudel";
                File.AppendAllText(path, tekst);
                Console.WriteLine("----------------------------");
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                Invetuur.Inv();
                Console.WriteLine("----------------------------");
            }
            else if (Vesi == "jäta maha")
            {
                Console.WriteLine("Lööd veepudelit jalaga teisele poole koopa seina ja see jääb sinna.");
            }
            else goto Ves;
        }
        public static void Sokolaad()
        {
            Soko:
            Console.WriteLine("Leiad maast šokolaadi! 'korja üles' või 'jäta maha'");
            string SokLad = Console.ReadLine();
            if (SokLad == "korja üles")
            {
                string tekst = "\nsokolaad";
                File.AppendAllText(path, tekst);
                Console.WriteLine("----------------------------");
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                Invetuur.Inv();
                Console.WriteLine("----------------------------");
            }
            else if (SokLad == "jäta maha")
            {
                Console.WriteLine("Astud šokolaaditahvlile peale ja kõnnid minema.");
            }
            else goto Soko;
        }
        public static void Kypsisepakk()
        {
            Kyp:
            Console.WriteLine("Leiad maast küpsisepaki! 'korja üles' või 'jäta maha'");
            string KypPak = Console.ReadLine();
            if (KypPak == "korja üles")
            {
                string tekst = "\nkypsisepakk";
                File.AppendAllText(path, tekst);
                Console.WriteLine("----------------------------");
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                Invetuur.Inv();
                Console.WriteLine("----------------------------");
            }
            else if (KypPak == "jäta maha")
            {
                Console.WriteLine("Kõnnid ahvatlevast küpsisepakist mööda.");
            }
            else goto Kyp;
        }
        public static void Coca()
        {
            CocaC:
            Console.WriteLine("Leiad maast Coca-Cola pudeli! 'korja üles' või 'jäta maha'");
            string Coca = Console.ReadLine();
            if (Coca == "korja üles")
            {
                string tekst = "\nCoca-Cola";
                File.AppendAllText(path, tekst);
                Console.WriteLine("----------------------------");
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                Invetuur.Inv();
                Console.WriteLine("----------------------------");
            }
            else if (Coca == "jäta maha")
            {
                Console.WriteLine("Kõnnid mööda kihisevast joogist.");
            }
            else goto CocaC;
        }

        public static void Kooba()
        {
            path = @"../../../Invetory.txt";
            File.Delete(path);
            //-esimene suuna valik
            Console.WriteLine("Kas soovite minna vasakule või paremale?");
            string suund = Console.ReadLine();
            if (suund == "vasakule")

            {
                alg:
                Console.WriteLine("Kas soovite minna vasakule või paremale?");
                string suund2 = Console.ReadLine();
                if (suund2 == "vasakule")
                {
                    

                    //politsei - KRISTEL
                    Console.WriteLine("Kas soovite minna vasakule või paremale?");
                    string suund4 = Console.ReadLine();
                    if (suund4 == "vasakule")
                    {
                        Console.WriteLine("Kas soovite minna vasakule või paremale?");
                        string suund6 = Console.ReadLine();
                        if (suund6 == "vasakule")
                        {
                            Koobas.Kypsisepakk();
                            //VÄLJA
                            goto alg;
                        }
                        else if (suund6 == "paremale")
                        {
                            Koobas.Kypsisepakk();
                            //puhkeala
                            Console.WriteLine("Kas soovite minna vasakule või paremale?");
                            string suund8 = Console.ReadLine();
                            if (suund8 == "vasakule")
                            {
                                //rott
                                //puhkeala
                                goto alg;
                            }
                            else if (suund8 == "paremale")
                            {
                                Koobas.Kypsisepakk();
                                goto koik;
                            }
                        }

                    }

                    else if (suund4 == "paremale")
                    {
                        Koobas.Vesi();
                        goto koik;
                    }
                }
                else if (suund2 == "paremale")
                {
                    
                    //vanemate elajate ründamine - KRISTEL
                    Console.WriteLine("Kas soovite minna vasakule või paremale?");
                    string suund5 = Console.ReadLine();
                    if (suund5 == "vasakule")
                    {
                        Koobas.Kypsisepakk();
                        //puhkeala
                        Console.WriteLine("Kas soovite minna vasakule või paremale?");
                        string suund8 = Console.ReadLine();
                        if (suund8 == "vasakule")
                        {
                            //rott
                            //puhkeala
                            goto alg;
                        }
                        else if (suund8 == "paremale")
                        {
                            Koobas.Vesi();
                            //VÄLJAS
                            goto koik;
                        }
                    }
                    else if (suund5 == "paremale")
                    {
                        //puhkeala
                        Koobas.Vesi();
                        goto koik;
                    }
                }
            }

            else if (suund == "paremale")
            {
                
                //vanemate elajate ründamine - KRISTEL
                algu:
                Console.WriteLine("Kas soovite minna vasakule või paremale?");
                string suund3 = Console.ReadLine();
                if (suund3 == "vasakule")
                {

                    //vanemate elajate ründamine - KRISTEL
                    Console.WriteLine("Kas soovite minna vasakule või paremale?");
                    string suund5 = Console.ReadLine();
                    if (suund5 == "vasakule")
                    {
                        Koobas.Sokolaad();
                        //puhkeala
                        Console.WriteLine("Kas soovite minna vasakule või paremale?");
                        string suund8 = Console.ReadLine();
                        if (suund8 == "vasakule")
                        {
                            Koobas.Coca();
                            //VÄLJAS
                            goto koik;
                        }
                        else if (suund8 == "paremale")
                        {   //rott aitab välja
                            //puhkeala 
                            //VÄLJAS
                            goto algu;
                        }
                    }
                    else if (suund5 == "paremale")
                    {
                        //rott aitab välja
                        //puhkeala 
                        //VÄLJAS
                        goto algu;
                    }

                }

                else if (suund3 == "paremale")
                {
                    Koobas.Sokolaad();
                    Console.WriteLine("Kas soovite minna vasakule või paremale?");
                    string suund7 = Console.ReadLine();
                    if (suund7 == "vasakule")
                    {
                        //rott
                        //puhkeala
                        Koobas.Vesi();
                        //VÄLJAS
                        goto algu;
                    }
                    else if (suund7 == "paremale")
                    {

                        //politsei- KRISTEL
                        Console.WriteLine("Kas soovite minna vasakule või paremale?");
                        string suund9 = Console.ReadLine();
                        if (suund9 == "vasakule")
                        {
                            //rott
                            //puhkeala
                            //VÄLJAS
                            goto koik;
                        }
                        else if (suund9 == "paremale")
                        {
                            Console.WriteLine("Tuleb kiiresti välja saada!");
                            //VÄLJAS
                            goto algu;

                        }
                    }
                }
            }
            koik:
            Console.WriteLine("*Õhk, vabadus on see mida ma tunnen! Ma leidsin tee koopast välja!*");
        }
    }
}