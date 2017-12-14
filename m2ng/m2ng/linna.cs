using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class linna
    {
        public static void linnas()
        {
            Console.WriteLine("*Vaatan ringi:* Kas kuskil võiks olla keegigi, kes mind apteeki juhatada oskaks?");
            Console.ReadKey();
            Console.WriteLine("Ohoh! Seal ongi üks koristaja! Tema tunneb kindlasti seda linna!");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Tere! Kas te oskate mind aidata?");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*Koristaja*: Tere, milles on probleem?");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("Olen siin linnas esimest korda ja sooviksin minna lähimasse apteeki. Kas te oskate mind juhatada?");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*Koristaja*: Muidugi! Kõige lähemal asub arvatavasti Lare'i apteek. Kas ma seletan teile või annan teile linnakaardi? Kaardi eest peate aga maksma 50 senti, sest see on kahjuks minu viimane ja mul pole hetkel võimalik uut ostma minna.");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("*Hmm... Haarab rahakoti järgi...*");
            Console.ReadKey();
            valik:
            Console.WriteLine("'osta kaart' või 'küsi seletust'");
            var valik = Console.ReadLine();
            Console.Clear();

            if (valik == "osta kaart")
            {
                Console.WriteLine("Kaart oleks vist parem variant. *Naeran*: Mulle ei jää asjad hästi meelde.");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                //VAJA TEHA RAHA MAHA MINEK!
                Console.ReadKey();
                Console.WriteLine("*Koristaja:* Arusaadav, näe, ole aga lahke!");
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine("Tänan. *Maksan raha* Head päeva jätku!");
                Console.ReadKey();
                Console.WriteLine("*Kõndides vaatan kaarti ja mõtlen:* Siin on ju nii segased joonised ja tekst kõik võõrkeeles! Sellest ma küll midagi aru ei saa! Aga pole hullu, küsin siis linnaelanikelt.");
            }
            else if (valik == "küsi seletust")
            {
                Console.WriteLine("Teate, ma kaarte hästi ei mõista. Sooviksin vist seletust.");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*Koristaja:* Arusaadav! Te peate lihtsalt kõndima lennujaamast välja suure rohelise hooneni ja keerama sealt vasakule. Siis näete suurt puud, minge paremale, peale seda uuesti paremale ning teeristile jõudes vasakule. Siis näete suurt kaubahoonet ja sealt otse edasi minnes jõuategi apteeki. Mõistate?");
                Console.ResetColor();
                Console.WriteLine("*Segaduses*: Ahah... Vist küll, suur tänu teile!");
                Console.ReadKey();
                Console.WriteLine("*Endamisi mõeldes*: Sellest ma küll midagi aru ei saanud, kuid parem ei hakka naist rohkem tüütama. Uurin parem linlastelt!");
            }
            else goto valik;
            Console.ReadKey();
            Console.WriteLine("*Lahkun aeglaselt.* Tegelikult ma ei usu, et see nii keeruline saab olla. Kindlasti olen juba poole tunni pärast haiglas!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("*Peale veidikest jalutamist jõuan linnakesse, kuhu ma minema pidin.*");
            //Linna jõudes
            Console.ReadKey();
            Console.WriteLine("Hmm, milline ilus linn. Nüüd tuleb vaid otsida inimesi, kes mind apteeki juhatada oskaks.");
            Console.ReadKey();
            valik2:
;           Console.WriteLine("*Näha on üks lonkav vanainimene.* Kas 'kõnnin mööda' või 'küsin abi'?");
            var valik2 = Console.ReadLine();

            if (valik2 == "kõnnin mööda")
            {
                Console.WriteLine("Hmm, ma ei usu, et tema mind aidata oskab. Vaatan edasi!");
                Console.ReadKey();
                Console.Clear();

            }
            else if (valik2 == "küsin abi")
            {
                valik3:
                Console.WriteLine("Kuidas alustaksin vestlust? Kas:");
                Console.WriteLine("1: Tervist, vanaproua, kas te aitaksite mind palun?");
                Console.WriteLine("2: Jou, kas aitad mind v?");
                Console.WriteLine("3: Tere, kas te oskaksite mind palun edasi juhatada?");
                var valik3 = Console.ReadLine();
                Console.Clear();

                if (valik3 == "1")
                {
                    Console.WriteLine("Tervist, vanaproua, kas te aitaksite mind palun?");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Vanaproua*:Oi, pojuke, mis vanaproua mina olen, mina pole veel abieluski, mina veel alles preili!");
                    Console.ResetColor();
                    Console.ReadKey();
                    val:
                    Console.WriteLine("Mida vastan?");
                    Console.WriteLine("a: Ah, mis sa ajad, sa ju vana nagu muld!");
                    Console.WriteLine("b: Vabandust, oleksin pidanud kohe aru saama!");
                    var val = Console.ReadLine();
                    Console.Clear();
                    if (val == "a")
                    {
                        Console.WriteLine("Ah, mis sa ajad, sa ju vana nagu muld!");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("*Vanaproua:* Kuidas palun!? Kao mu silmist!");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine("*Kõnnin lihtsalt edasi. Kuskil peab ju keegi mind ikka aitama.*");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (val == "b")
                    {
                        Console.WriteLine("Vabandust, oleksin pidanud kohe aru saama!");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("*Vanaproua*: Ah, pole hullu, ma niisama! Kuhu sul minna on vaja?");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine("Ma sooviksin minna Lare'i apteeki. Kuhu ma minema pean?");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("*Vanaproua:* Oii, seda kohta mina tean! Sealt ostan mina oma selja jaoks rohtu! Sa pead lihtsalt keerama siit vasakule, siis minema mööda teed paremale ja juba peaksidki nägema suurt maja, kus on APTEEK suurelt kirjas.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine("Aitäh! Head päeva! *Näen vanaproua kellalt, et kell on juba 13:50*");
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("*Vanaproua:* Head päeva sullegi!");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.WriteLine("*Kõnnin vanaproua juhatatud teed pidi edasi*");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else goto val;
                }
                else if (valik3 == "2")
                {
                    Console.WriteLine("Jou, kas aitad mind v?");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Vanaproua:* Kuidas palun!? Kas sa saad, kao siit minema ja mine kooli keelt õppima! *Virutab vihmavarjuga*");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vihmavari vähendas su HP kolme võrra.");
                    Console.ResetColor();
                    karakter.HP -= 3;
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Sinu HP on: " + karakter.HP);
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.WriteLine("*Kõnnin lihtsalt edasi. Kuskile pean ju ikka välja jõudma.*");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (valik3 == "3")
                {
                    Console.WriteLine("Tere, kas te oskaksite mind palun edasi juhatada?");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Vanaproua*: Muidugi, lapsuke! Kuhu sul minna on vaja?");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.WriteLine("Mul oleks vaja minna Lare'i apteeki.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Vanaproua*:Sa pead keerama siit vasakule, siis minema mööda teed paremale ja juba peaksidki nägema suurt maja, kus on APTEEK suurelt kirjas.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.WriteLine("Selge! Aitäh teile! *Näeb vanaproua kellalt, et kell on 13:45* Pean nüüd kiirustama! Head päeva!");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Vanaproua*: Head päeva!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.WriteLine("*Kõnnin vanaproua juhatatud teed pidi edasi*");
                    Console.ReadKey();
                    Console.Clear();
                }
                else goto valik3;
            }
            else goto valik2;
        }

        public static void linn()
        {
            valik4:
            Console.WriteLine("*Näen teel noort naist lapsega.* Kas: 'jalutan mööda' või 'küsin juhiseid'");
            var valik4 = Console.ReadLine();
            Console.Clear();
            if (valik4 == "jalutan mööda")
            {
                Console.WriteLine("Ma arvan, et tal on muudki teha. Liigun edasi.");
                Console.ReadKey();
                Console.WriteLine("Pagan! Ma ei mõista kohe üldse, kus ma olen! *Näen üht noort meest* Tema tundub ärimehe moodi! Tema oskab kindlasti seletada!");
                Console.ReadKey();
                Console.WriteLine("Tere! Kas te oskate mind Lare'i apteeki juhatada?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*Mees:* Muidugi! Te peate lihtsalt kõndima siit paremale ja siis 4 kilomeetrit edasi. Siis näete suurt maja - see ongi apteek!");
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine("Suur tänu!");
            }
            else if (valik4 == "küsin juhiseid")
            {
                Console.WriteLine("Tere! Kas oskate mind palun Lare'i apteeki juhatada?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*Naine:* Jah, sa pead siit minema paremale ja kõndima siis umbes 5 kilomeetrit otse edasi. Siis peaksidki märkama suurt maja, see ongi apteek.");
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine("Aitäh!");

            }
            else goto valik4;
            Console.ReadKey();
            Console.WriteLine("*Mõne aja pärast:*Hmm, olen kõndinud nii paremale kui ka edasi, kuid maja pole näha. Ehk peaksin korra veel küsida proovima?");
            Console.ReadKey();
            valik5:
            Console.WriteLine("Seal ongi üks nooruk. Kas 'kõnnin mööda' või 'küsin abi'?");
            string valik5 = Console.ReadLine();
            Console.Clear();

            if (valik5 == "kõnnin mööda")
            {
                Console.WriteLine("Ta tundub liiga noor, et täpset seletust anda. Küsin parem kõrvalolevalt mehelt.");
                Console.ReadKey();
                Console.WriteLine("Tere! Kas te oskate mind Lare'i apteeki juhatada?");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*Mees:* Muidugi, see on ju otse siin nurga taga! Te peate lihtsalt ümber selle maja minema.");
                Console.ResetColor();
                Console.ReadKey();
                Console.WriteLine("Oh, kas tõesti!? Oh mind lolli! Aitäh.");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*Mees:* Pole hullu, head päeva!");
                Console.ResetColor();

            }

            else if (valik5 == "küsin abi")
            {
                Console.WriteLine("Tere. Kas sa oskaksid mind edasi juhatada? Soovin Lare'i apteeki minna.");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("*Nooruk:* Jah, see on kohe siin nurga taga! Paljud turistid ei leia seda kohe üles.");
                Console.ResetColor();
                Console.WriteLine("Oh, kas tõesti! Olen juba 15 minutit siin ringi käinud. Aitäh!");
            }
            else goto valik5;
            Console.ReadKey();
            Console.Clear();
            string apteekvaljast = System.IO.File.ReadAllText(@"..\..\info\apteekvaljast.txt");
            Console.WriteLine(apteekvaljast);
            Console.WriteLine("*Peale pikka jalutuskäiku jõunagi lõpuks apteeki. Ma ei suuda uskuda, et seda varem üles ei leidnud, kuid mis siis ikka! Nüüd jääb üle vaid veel rohi osta.*");
            Console.ReadKey();
        }
    }
}