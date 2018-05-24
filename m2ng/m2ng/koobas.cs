using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Koobas:Karakter
    {
        public static string path;
        //9 toitu. 4 vett, 2 sokolaadi, 2 pakki kypsist, 1 coca cola
        /// <summary>
        /// Leiad maast veepudeli, võimalus kas üles korjata või maja jätta.
        /// </summary>
        public static void Vesi()
        {
            while (true)
            {
                Console.WriteLine("Leiad maast veepudeli! 'korja üles' või 'jäta maha'");
                Console.ResetColor();
                string Vesi = Console.ReadLine();
                if (Vesi == "korja üles")
                {
                    string tekst = "\nveepudel";
                    File.AppendAllText(path, tekst);
                    Invetuur.Invcheck();
                    break;
                }
                else if (Vesi == "jäta maha")
                {
                    Console.WriteLine("Lööd veepudelit jalaga teisele poole koopa seina ja see jääb sinna.");
                    break;
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Leiad maast šokolaadi, võimalus kas üles korjata või maja jätta.
        /// </summary>
        public static void Sokolaad()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Leiad maast šokolaadi! 'korja üles' või 'jäta maha'");
                Console.ResetColor();
                string SokLad = Console.ReadLine();
                if (SokLad == "korja üles")
                {
                    string tekst = "\nsokolaad";
                    File.AppendAllText(path, tekst);
                    Invetuur.Invcheck();
                    break;
                }
                else if (SokLad == "jäta maha")
                {
                    Console.WriteLine("Astud šokolaaditahvlile peale ja kõnnid minema.");
                    break;
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Leiad maast küpsisepaki, võimalus kas üles korjata või maja jätta.
        /// </summary>
        public static void Kypsisepakk()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Leiad maast küpsisepaki! 'korja üles' või 'jäta maha'");
                Console.ResetColor();
                string KypPak = Console.ReadLine();
                if (KypPak == "korja üles")
                {
                    string tekst = "\nkypsisepakk";
                    File.AppendAllText(path, tekst);
                    Invetuur.Invcheck();
                    break;
                }
                else if (KypPak == "jäta maha")
                {
                    Console.WriteLine("Kõnnid ahvatlevast küpsisepakist mööda.");
                    break;
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Leiad maast coca pudeli, võimalus kas üles korjata või maja jätta.
        /// </summary>
        public static void Coca()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Leiad maast Coca-Cola pudeli! 'korja üles' või 'jäta maha'");
                Console.ResetColor();
                string Coca = Console.ReadLine();
                if (Coca == "korja üles")
                {
                    string tekst = "\nCoca-Cola";
                    File.AppendAllText(path, tekst);
                    Invetuur.Invcheck();
                    break;
                }
                else if (Coca == "jäta maha")
                {
                    Console.WriteLine("Kõnnid mööda kihisevast joogist.");
                    break;
                }
            }
            Console.ReadKey();
        }
        //--KOOBAS--
        /// <summary>
        /// Seiklemine koopas, kuhu sattusid läbi kanalisatsiooni.
        /// </summary>
        public static void Kooba()
        {
            path = @"../../info/Invetory.txt";
            Console.WriteLine("Kanalisatsiooni läbi oled sattunud koopasse.");
            Console.ReadKey();
            //suund:
            while (true)
            {
                Console.WriteLine("Võimalik on minna kas 'paremale' või 'vasakule'.");
                string suund = Console.ReadLine();
                Console.Clear();
                if (suund == "vasakule")
                {
                    Console.WriteLine("Siin kooparuumis ei paista olevat midagi. Saab rahulikult hingata.");
                    while (true)
                    {
                        Console.WriteLine("Avastad enda ees kaks teed. 'paremale' või 'vasakule'");
                        string suund2 = Console.ReadLine();
                        Console.Clear();
                        if (suund2 == "vasakule")
                        {
                            KoobasFunc.PolitseiLucky();
                            while (true)
                            {
                                Console.WriteLine("Toibud šhokist peale politseiga kohtumist ja liigud kas 'paremale' või 'vasakule'.");
                                string suund4 = Console.ReadLine();
                                Console.Clear();
                                if (suund4 == "vasakule")
                                {
                                    Console.WriteLine("Siin ruumis ei ole midagi head ega ohtlikku.");
                                    while (true)
                                    {
                                        Console.WriteLine("Tee haruneb taas kaheks. 'paremale' või 'vasakule'");
                                        string suund6 = Console.ReadLine();
                                        Console.Clear();
                                        if (suund6 == "vasakule")
                                        {
                                            Koobas.Kypsisepakk();
                                            Koobas.Ryne();
                                            break;
                                        }
                                        else if (suund6 == "paremale")
                                        {
                                            Koobas.Kypsisepakk();
                                            while (true)
                                            {
                                                Console.WriteLine("Liigud 'paremale' või 'vasakule'?");
                                                string suund8 = Console.ReadLine();
                                                Console.Clear();
                                                if (suund8 == "vasakule")
                                                {
                                                    KoobasFunc.Rott();
                                                    break;
                                                }
                                                else if (suund8 == "paremale")
                                                {
                                                    Koobas.Kypsisepakk();
                                                    break;
                                                }
                                                else
                                                {
                                                    continue;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                                else if (suund4 == "paremale")
                                {
                                    Koobas.Vesi();
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            break;
                        }
                        else if (suund2 == "paremale")
                        {
                            Koobas.Ryne();
                            while (true)
                            {
                                Console.WriteLine("Peale võitlust toibununa leiad enda ees 2 koopaharu. Kuhu minna, 'paremale' või 'vasakule'?");
                                string suund5 = Console.ReadLine();
                                Console.Clear();
                                if (suund5 == "vasakule")
                                {
                                    Koobas.Kypsisepakk();
                                    while (true)
                                    {
                                        Console.WriteLine("Liigud 'paremale' või 'vasakule'?");
                                        string suund8 = Console.ReadLine();
                                        Console.Clear();
                                        if (suund8 == "vasakule")
                                        {
                                            KoobasFunc.Rott();
                                            break;
                                        }
                                        else if (suund8 == "paremale")
                                        {
                                            Koobas.Vesi();
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                else if (suund5 == "paremale")
                                {
                                    Koobas.Vesi();
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                }

                else if (suund == "paremale")
                {
                    Koobas.Ryne();
                    while (true)
                    {
                        Console.WriteLine("Värske õhu lõhna on tunda. Teid on 2, 'paremale' või 'vasakule'.");
                        string suund3 = Console.ReadLine();
                        Console.Clear();
                        if (suund3 == "vasakule")
                        {
                            Koobas.Ryne();
                            Koobas.S88();
                            while (true)
                            {
                                Console.WriteLine("Kaklusest toibununa liigud 'paremale' või 'vasakule'");
                                string suund5 = Console.ReadLine();
                                Console.Clear();
                                if (suund5 == "vasakule")
                                {
                                    Koobas.Sokolaad();
                                    while (true)
                                    {
                                        Console.WriteLine("Peale magusa leidmist kuuled seina tagant veesolinat. Kas liigud edasi 'paremale' või 'vasakule'?");
                                        string suund8 = Console.ReadLine();
                                        if (suund8 == "vasakule")
                                        {
                                            Koobas.Coca();
                                            break;
                                        }
                                        else if (suund8 == "paremale")
                                        {
                                            KoobasFunc.Rott();
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                else if (suund5 == "paremale")
                                {
                                    KoobasFunc.RottValja();
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            break;
                        }

                        else if (suund3 == "paremale")
                        {
                            Koobas.Sokolaad();
                            while (true)
                            {
                                Console.WriteLine("Edasi viib endiselt 2 teed. Kas 'paremale' või 'vasakule'?");
                                string suund7 = Console.ReadLine();
                                Console.Clear();
                                if (suund7 == "vasakule")
                                {
                                    KoobasFunc.Rott();
                                    Koobas.Vesi();
                                    break;
                                }
                                else if (suund7 == "paremale")
                                {

                                    KoobasFunc.Politsei();

                                    while (true)
                                    {
                                        Console.WriteLine("Vabadus tundub õige lähedal. Ees on 2 teed: 'paremale' või 'vasakule'");
                                        string suund9 = Console.ReadLine();
                                        Console.Clear();
                                        if (suund9 == "vasakule")
                                        {
                                            KoobasFunc.RottValja();
                                            break;
                                        }
                                        else if (suund9 == "paremale")
                                        {
                                            break;

                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.Clear();
            Console.WriteLine("*Õhk, vabadus on see mida ma tunnen! Ma leidsin tee koopast välja!*");
            Console.ReadKey();
        }
        /// <summary>
        /// Kui stamina otsa saab, siis on võimalus süüa, et see taastada.
        /// </summary>
        public static void S88()
        {
            path = @"../../info/Invetory.txt";
            Console.Clear();
            Console.WriteLine("Sul ei ole piisavalt staminat!");
            Console.WriteLine("Stamina taastamiseks söö/joo midagi, kui sul on seljakotis midagi, mida süüa/juua.");
            Console.ReadKey();
            while (true)
            {
                Invetuur.Invcheck();
                Console.WriteLine("Soovid/on sul midagi süüa/juua oma seljakotist? 'jah' või 'ei'");
                string onmidagi = Console.ReadLine();
                if (onmidagi == "jah")
                {
                    Console.WriteLine("Mida sa soovid süüa/juua?");
                    Console.WriteLine("(Kirjuta seljakotis olev toit/jook selgelt välja ja samamoodi, nagu seljakotis kirjas.)");
                    string s88k = Console.ReadLine();
                    Console.Clear();
                    string[] kontro = System.IO.File.ReadAllLines(path);
                    foreach (string asi in kontro)
                    {
                        if (asi == s88k)
                        {
                            if (s88k == "pakk plaastreid")
                            {
                                Console.WriteLine("Plaastrid ei ole söömiseks..");
                                Console.ReadKey();
                                break;
                            }
                            else if (s88k == "rohi 'Calvan'")
                            {
                                Console.WriteLine("See rohi on su kaksikule!");
                                Console.ReadKey();
                                break;
                            }
                            else if (s88k == " ")
                            {
                                Console.WriteLine("Õhku ei ole võimalik süüa!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Said selle toidu/joogi söömise/joomise eest +30 staminat!");
                                Console.ReadKey();
                                Karakter.Stamina += 30;
                                string text = File.ReadAllText(path);
                                text = text.Replace(s88k, " ");
                                File.WriteAllText(path, text);
                                break;
                            }

                        }
                        else if (asi != s88k)
                        {
                        }
                    }
                    Invetuur.Invcheck();
                    Karakter.Staminacheck();
                }

                else if (onmidagi == "ei")
                {
                    Console.WriteLine("Otsustad mitte teha söögipausi ja kõnnid edasi.");
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Ründad vastast lüües teda pähe.
        /// </summary>
        public static void Pahe()
        {
            if (Karakter.Stamina >= 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Karakter.Stamina -= 30;
                Console.WriteLine("Vastase HP on: " + Karakter.EnemyHP);
                Karakter.EnemyHP -= 30;
                Console.WriteLine("Lõid teda pähe ja ta HP vähenes 30 võrra.");
                Console.WriteLine("Tema HP on: " + Karakter.EnemyHP);
                Console.ResetColor();
            }
            else if (Karakter.Stamina < 30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Staminat ei ole piisavalt, et seda käiku teha.");
                Console.WriteLine("Söö midagi seljakotist või on mäng läbi!");
                Console.ResetColor();
                S88();
                if (Karakter.Stamina >= 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Karakter.Stamina -= 30;
                    Console.WriteLine("Vastase HP on: " + Karakter.EnemyHP);
                    Karakter.EnemyHP -= 30;
                    Console.WriteLine("Lõid teda pähe ja ta HP vähenes 30 võrra.");
                    Console.WriteLine("Tema HP on: " + Karakter.EnemyHP);
                    Console.ResetColor();
                }
                else if (Karakter.Stamina < 30)
                {
                    KoobasFunc.MangLabi();
                }
            }
        }
        /// <summary>
        /// Ründad vastast lüües teda kõhtu.
        /// </summary>
        public static void Kohtu()
        {
            if (Karakter.Stamina >= 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Karakter.Stamina -= 20;
                Console.WriteLine("Vastase HP on: " + Karakter.EnemyHP);
                Karakter.EnemyHP -= 20;
                Console.WriteLine("Lõid teda pähe ja ta HP vähenes 20 võrra.");
                Console.WriteLine("Tema HP on: " + Karakter.EnemyHP);
                Console.ResetColor();
            }
            else if (Karakter.Stamina < 20)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Staminat ei ole piisavalt, et seda käiku teha.");
                Console.WriteLine("Söö midagi seljakotist või on mäng läbi!");
                Console.ResetColor();
                S88();
                if (Karakter.Stamina >= 20)
                {
                    Karakter.Stamina -= 20;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vastase HP on: " + Karakter.EnemyHP);
                    Karakter.EnemyHP -= 20;
                    Console.WriteLine("Lõid teda pähe ja ta HP vähenes 20 võrra.");
                    Console.WriteLine("Tema HP on: " + Karakter.EnemyHP);
                    Console.ResetColor();
                }
                else if (Karakter.Stamina < 20)
                {
                    KoobasFunc.MangLabi();
                }
            }
        }
        /// <summary>
        /// Koopaelanik ründab sind, pead teda alistama.
        /// </summary>
        public static void Ryne()
        {
            //Vaenlasele tuleb teha eraldi class, sest hetkesel juhul ta
            //resetib ka karacteri HP.
            Karakter vaenlane = new Karakter();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Koopaelanik tuleb kallale!");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Lööd 'pähe'(-30 staminat) või 'kõhtu'(-20 staminat)");
                Console.ResetColor();
                string vas1 = Console.ReadLine();
                if (vas1 == "pähe")
                {
                    Pahe();
                    Karakter.Staminacheck();
                    if (Karakter.EnemyHP > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vastane on uimane, saad uuesti lüüa!");
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Lööd 'pähe'(-30 staminat) või 'kõhtu'(-20 staminat)");
                            Console.ResetColor();
                            string vas2 = Console.ReadLine();
                            if (vas2 == "pähe")
                            {
                                Pahe();
                                Karakter.Staminacheck();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vastane on alistatud! Liigud edasi nagu midagi poleks juhtunud.");
                                Console.ResetColor();
                                break;
                            }
                            else if (vas2 == "kõhtu")
                            {
                                Kohtu();
                                Karakter.Staminacheck();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vastane on alistatud! Liigud edasi nagu midagi poleks juhtunud.");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    }
                }
                else if (vas1 == "kõhtu")
                {
                    Kohtu();
                    Karakter.Staminacheck();
                    if (Karakter.EnemyHP > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Vastane taastub sellest kiiresti ja lööb sind õlga. Kaotad 14 HP.");
                        Karakter.HP -= 14;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Sinu HP on: " + Karakter.HP);
                        Console.ForegroundColor = ConsoleColor.Red;
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Lööd 'pähe'(-30 staminat) või 'kõhtu'(-20 staminat)");
                            Console.ResetColor();
                            string vas3 = Console.ReadLine();
                            if (vas3 == "pähe")
                            {
                                Pahe();
                                Karakter.Staminacheck();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vastane on alistatud! Liigud edasi nagu midagi poleks juhtunud.");
                                Console.ResetColor();
                                break;
                            }
                            else if (vas3 == "kõhtu")
                            {
                                Kohtu();
                                Karakter.Staminacheck();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vastane on alistatud! Liigud edasi nagu midagi poleks juhtunud.");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }
}