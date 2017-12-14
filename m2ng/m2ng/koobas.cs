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
        //9 toitu. 4 vett, 2 sokolaadi, 2 pakki kypsist, 1 coca cola
        public static void Vesi()
        {
            Ves:
            Console.WriteLine("Leiad maast veepudeli! 'korja üles' või 'jäta maha'");
            Console.ResetColor();
            string Vesi = Console.ReadLine();
            if (Vesi == "korja üles")
            {
                string tekst = "\nveepudel";
                File.AppendAllText(path, tekst);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------------------------");
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                Invetuur.Inv();
                Console.WriteLine("----------------------------");
                Console.ResetColor();
            }
            else if (Vesi == "jäta maha")
            {
                Console.WriteLine("Lööd veepudelit jalaga teisele poole koopa seina ja see jääb sinna.");
            }
            else goto Ves;
            Console.ReadKey();
        }
        public static void Sokolaad()
        {
            Soko:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Leiad maast šokolaadi! 'korja üles' või 'jäta maha'");
            Console.ResetColor();
            string SokLad = Console.ReadLine();
            if (SokLad == "korja üles")
            {
                string tekst = "\nsokolaad";
                File.AppendAllText(path, tekst);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------------------------");
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                Invetuur.Inv();
                Console.WriteLine("----------------------------");
                Console.ResetColor();
            }
            else if (SokLad == "jäta maha")
            {
                Console.WriteLine("Astud šokolaaditahvlile peale ja kõnnid minema.");
            }
            else goto Soko;
            Console.ReadKey();
        }
        public static void Kypsisepakk()
        {
            Kyp:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Leiad maast küpsisepaki! 'korja üles' või 'jäta maha'");
            Console.ResetColor();
            string KypPak = Console.ReadLine();
            if (KypPak == "korja üles")
            {
                string tekst = "\nkypsisepakk";
                File.AppendAllText(path, tekst);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------------------------");
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                Invetuur.Inv();
                Console.WriteLine("----------------------------");
                Console.ResetColor();
            }
            else if (KypPak == "jäta maha")
            {
                Console.WriteLine("Kõnnid ahvatlevast küpsisepakist mööda.");
            }
            else goto Kyp;
            Console.ReadKey();
        }
        public static void Coca()
        {
            CocaC:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Leiad maast Coca-Cola pudeli! 'korja üles' või 'jäta maha'");
            Console.ResetColor();
            string Coca = Console.ReadLine();
            if (Coca == "korja üles")
            {
                string tekst = "\nCoca-Cola";
                File.AppendAllText(path, tekst);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("----------------------------");
                Console.WriteLine("Sinu seljakotis on nüüd: ");
                Invetuur.Inv();
                Console.WriteLine("----------------------------");
                Console.ResetColor();
            }
            else if (Coca == "jäta maha")
            {
                Console.WriteLine("Kõnnid mööda kihisevast joogist.");
            }
            else goto CocaC;
            Console.ReadKey();
        }
        //--KOOBAS--
        public static void Kooba()
        {
            path = @"../../../Invetory.txt";
            File.Delete(path);
            string tekst = "---Tühi koht---";
            File.AppendAllText(path, tekst);
            suund:
            Console.WriteLine("Läbi luugi oled sattunud koopasse.");
            Console.WriteLine("Võimalik on minna kas 'paremale' või 'vasakule'.");
            string suund = Console.ReadLine();
            Console.Clear();
            if (suund == "vasakule")
            {
                Console.WriteLine("Siin kooparuumis ei paista olevat midagi. Saab rahulikult hingata.");
                alg:
                suund2:
                Console.WriteLine("Avastad enda ees kaks teed. 'paremale' või 'vasakule'");
                string suund2 = Console.ReadLine();
                Console.Clear();
                if (suund2 == "vasakule")
                {
                    KoobasFunc.PolitseiLucky();
                    suund4:
                    Console.WriteLine("Toibud šhokist peale politseiga kohtumist ja liigud kas 'paremale' või 'vasakule'.");
                    string suund4 = Console.ReadLine();
                    Console.Clear();
                    if (suund4 == "vasakule")
                    {
                        Console.WriteLine("Siin ruumis ei ole midagi head ega ohtlikku.");
                        suund6:
                        Console.WriteLine("Tee haruneb taas kaheks. 'paremale' või 'vasakule'");
                        string suund6 = Console.ReadLine();
                        Console.Clear();
                        if (suund6 == "vasakule")
                        {
                            Koobas.Kypsisepakk();
                            Koobas.Ryne();
                            goto alg;
                        }
                        else if (suund6 == "paremale")
                        {
                            Koobas.Kypsisepakk();
                            suund8:
                            Console.WriteLine("Liigud 'paremale' või 'vasakule'?");
                            string suund8 = Console.ReadLine();
                            Console.Clear();
                            if (suund8 == "vasakule")
                            {
                                KoobasFunc.Rott();
                                goto alg;
                            }
                            else if (suund8 == "paremale")
                            {
                                Koobas.Kypsisepakk();
                                goto koik;
                            }
                            else goto suund8;
                        }
                        else goto suund6;

                    }

                    else if (suund4 == "paremale")
                    {
                        Koobas.Vesi();
                        goto koik;
                    }
                    else goto suund4;
                }
                else if (suund2 == "paremale")
                {
                    Koobas.Ryne();
                    suund5:
                    Console.WriteLine("Peale võitlust toibununa leiad enda ees 2 koopaharu. Kuhu minna, 'paremale' või 'vasakule'?");
                    string suund5 = Console.ReadLine();
                    Console.Clear();
                    if (suund5 == "vasakule")
                    {
                        Koobas.Kypsisepakk();
                        suund8:
                        Console.WriteLine("Liigud 'paremale' või 'vasakule'?");
                        string suund8 = Console.ReadLine();
                        Console.Clear();
                        if (suund8 == "vasakule")
                        {
                            KoobasFunc.Rott();
                            goto alg;
                        }
                        else if (suund8 == "paremale")
                        {
                            Koobas.Vesi();
                            goto koik;
                        }
                        else goto suund8;
                    }
                    else if (suund5 == "paremale")
                    {
                        Koobas.Vesi();
                        goto koik;
                    }
                    else goto suund5;
                }
                else goto suund2;
            }

            else if (suund == "paremale")
            {
                Koobas.Ryne();
                algu:
                suund3:
                Console.WriteLine("Värske õhu lõhna on tunda. Teid on 2, 'paremale' või 'vasakule'.");
                string suund3 = Console.ReadLine();
                Console.Clear();
                if (suund3 == "vasakule")
                {
                    Koobas.Ryne();
                    Koobas.S88();
                    suund5:
                    Console.WriteLine("Kaklusest toibununa liigud 'paremale' või 'vasakule'");
                    string suund5 = Console.ReadLine();
                    Console.Clear();
                    if (suund5 == "vasakule")
                    {
                        Koobas.Sokolaad();
                        suund8:
                        Console.WriteLine("Peale magusa leidmist kuuled seina tagant veesolinat. Kas liigud edasi 'paremale' või 'vasakule'?");
                        string suund8 = Console.ReadLine();
                        if (suund8 == "vasakule")
                        {
                            Koobas.Coca();
                            goto koik;
                        }
                        else if (suund8 == "paremale")
                        {
                            KoobasFunc.Rott();
                            goto algu;
                        }
                        else goto suund8;
                    }
                    else if (suund5 == "paremale")
                    {
                        KoobasFunc.RottValja();
                        goto koik;
                    }
                    else goto suund5;

                }

                else if (suund3 == "paremale")
                {
                    Koobas.Sokolaad();
                    suund7:
                    Console.WriteLine("Edasi viib endiselt 2 teed. Kas 'paremale' või 'vasakule'?");
                    string suund7 = Console.ReadLine();
                    Console.Clear();
                    if (suund7 == "vasakule")
                    {
                        KoobasFunc.Rott();
                        Koobas.Vesi();
                        goto algu;
                    }
                    else if (suund7 == "paremale")
                    {

                        KoobasFunc.Politsei();

                        suund9:
                        Console.WriteLine("Vabadus tundub õige lähedal. Ees on 2 teed: 'paremale' või 'vasakule'");
                        string suund9 = Console.ReadLine();
                        Console.Clear();
                        if (suund9 == "vasakule")
                        {
                            KoobasFunc.RottValja();
                            goto koik;
                        }
                        else if (suund9 == "paremale")
                        {
                            goto algu;

                        }
                        else goto suund9;
                    }
                    else goto suund7;
                }
                else goto suund3;
            }
            else goto suund;
            koik:
            Console.WriteLine("*Õhk, vabadus on see mida ma tunnen! Ma leidsin tee koopast välja!*");
        }

        public static void S88()
        {
            Console.Clear();
            Console.WriteLine("Sul ei ole piisavalt staminat!");
            Console.WriteLine("Stamina taastamiseks söö/joo midagi, kui sul on seljakotis midagi, mida süüa/juua.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Sinu seljakotis on: ");
            Invetuur.Inv();
            Console.WriteLine("----------------------------");
            Console.ResetColor();
            Console.ReadKey();
            onmidagi:
            Console.WriteLine("Soovid/on sul midagi süüa/juua oma seljakotist? 'jah' või 'ei'");
            string onmidagi = Console.ReadLine();
            if (onmidagi == "jah")
            {
                Console.WriteLine("Mida sa soovid süüa/juua?");
                Console.WriteLine("(Kirjuta seljakotis olev toit/jook selgelt välja ja samamoodi, nagu seljakotis kirjas.)");
                string s88k = Console.ReadLine();
                string[] kontro = System.IO.File.ReadAllLines(path);
                foreach (string asi in kontro)
                {
                    if (asi == s88k)
                    {
                        Console.WriteLine("*otsid kotist, leiad selle toidu/joogi*: Mmm, " + s88k);
                        Console.WriteLine("Said selle toidu/joogi söömise/joomise eest +30 staminat!");
                        karakter.stamina += 30;
                        string text = File.ReadAllText(path);
                        text = text.Replace(s88k, "---Tühi koht---");
                        File.WriteAllText(path, text);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Sinu seljakotis on: ");
                        Invetuur.Inv();
                        Console.WriteLine("----------------------------");
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Hetkene stamina: " + karakter.stamina);
                        Console.ResetColor();
                        Console.ResetColor();
                    }
                    else if (asi != s88k)
                    {
                        Console.WriteLine("*otsid kotist, leiad eseme*: Pole " + s88k + "..");
                    }
                }
            }

            else if (onmidagi == "ei")
            {
                Console.WriteLine("Otsustad mitte teha söögipausi ja kõnnid edasi.");
            }
            else goto onmidagi;
            Console.ReadKey();
        }

        public static void Pahe()
        {
            if (karakter.stamina >= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                karakter.stamina -= 30;
                Console.WriteLine("Vastase HP on: " + karakter.EnemyHP);
                karakter.EnemyHP -= 30;
                Console.WriteLine("Lõid teda pähe ja ta HP vähenes 30 võrra.");
                Console.WriteLine("Tema HP on: " + karakter.EnemyHP);
                Console.ResetColor();
            }
            else if (karakter.stamina < 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Staminat ei ole piisavalt, et seda käiku teha.");
                Console.WriteLine("Söö midagi seljakotist või on mäng läbi!");
                Console.ResetColor();
                S88();
                if (karakter.stamina >= 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    karakter.stamina -= 30;
                    Console.WriteLine("Vastase HP on: " + karakter.EnemyHP);
                    karakter.EnemyHP -= 30;
                    Console.WriteLine("Lõid teda pähe ja ta HP vähenes 30 võrra.");
                    Console.WriteLine("Tema HP on: " + karakter.EnemyHP);
                    Console.ResetColor();
                }
                else if (karakter.stamina < 30)
                {
                    KoobasFunc.MangLabi();
                }
            }
        }

        public static void Kohtu()
        {
            if (karakter.stamina >= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                karakter.stamina -= 20;
                Console.WriteLine("Vastase HP on: " + karakter.EnemyHP);
                karakter.EnemyHP -= 20;
                Console.WriteLine("Lõid teda pähe ja ta HP vähenes 20 võrra.");
                Console.WriteLine("Tema HP on: " + karakter.EnemyHP);
                Console.ResetColor();
            }
            else if (karakter.stamina < 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Staminat ei ole piisavalt, et seda käiku teha.");
                Console.WriteLine("Söö midagi seljakotist või on mäng läbi!");
                Console.ResetColor();
                S88();
                if (karakter.stamina >= 20)
                {
                    karakter.stamina -= 20;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vastase HP on: " + karakter.EnemyHP);
                    karakter.EnemyHP -= 20;
                    Console.WriteLine("Lõid teda pähe ja ta HP vähenes 20 võrra.");
                    Console.WriteLine("Tema HP on: " + karakter.EnemyHP);
                    Console.ResetColor();
                }
                else if (karakter.stamina < 20)
                {
                    KoobasFunc.MangLabi();
                }
            }
        }

        public static void Ryne()
        {
            karakter vaenlane = new karakter();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Koopaelanuk tuleb kallale!");
            Console.WriteLine("Lööd 'pähe'(-30 staminat) või 'kõhtu'(-20 staminat)");
            Console.ResetColor();
            string vas1 = Console.ReadLine();
            if (vas1 == "pähe")
            {
                Pahe();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Hetkene stamina: " + karakter.stamina);
                Console.ResetColor();
                if (karakter.EnemyHP > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vastane on uimane, saad uuesti lüüa!");
                    vas2:
                    Console.WriteLine("Lööd 'pähe'(-30 staminat) või 'kõhtu'(-20 staminat)");
                    Console.ResetColor();
                    string vas2 = Console.ReadLine();
                    if (vas2 == "pähe")
                    {
                        Pahe();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Hetkene stamina: " + karakter.stamina);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vastane on alistatud! Liigud edasi nagu midagi poleks juhtunud.");
                        Console.ResetColor();
                    }
                    else if (vas2 == "kõhtu")
                    {
                        Kohtu();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Hetkene stamina: " + karakter.stamina);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vastane on alistatud! Liigud edasi nagu midagi poleks juhtunud.");
                        Console.ResetColor();
                    }
                    else goto vas2;
                }
            }
            else if (vas1 == "kõhtu")
            {
                Kohtu();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Hetkene stamina: " + karakter.stamina);
                Console.ResetColor();
                if (karakter.EnemyHP > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vastane taastub sellest kiiresti ja lööb sind õlga. Kaotad 14 HP.");
                    karakter.HP -= 14;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Sinu HP on: " + karakter.HP);
                    Console.ForegroundColor = ConsoleColor.Red;
                    vas2:
                    Console.WriteLine("Lööd 'pähe'(-30 staminat) või 'kõhtu'(-20 staminat)");
                    Console.ResetColor();
                    string vas3 = Console.ReadLine();
                    if (vas3 == "pähe")
                    {
                        Pahe();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Hetkene stamina: " + karakter.stamina);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vastane on alistatud! Liigud edasi nagu midagi poleks juhtunud.");
                        Console.ResetColor();
                    }
                    else if (vas3 == "kõhtu")
                    {
                        Kohtu();
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Hetkene stamina: " + karakter.stamina);
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vastane on alistatud! Liigud edasi nagu midagi poleks juhtunud.");
                        Console.ResetColor();
                    }
                    else goto vas2;
                }
            }
        }
    }
}