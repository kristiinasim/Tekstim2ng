using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class apteek
    {
        public static void apt()
        {
            Console.Clear();
            string apteekseest = System.IO.File.ReadAllText(@"..\..\info\apteekseest.txt");
            Console.WriteLine(apteekseest);
            Console.WriteLine("*Sisenen apteeki. Leti taga istub vanem naine ja lettidel on kõiksugu rohte külmetusrohtudest kuni retseptiravimiteni välja. Näen, et kell on juba 15:02.*");
            Console.ReadKey();
            Console.WriteLine("Tere!");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*Apteeker:* Tere! Kuidas ma sind aidata saan?");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("Mul oleks vaja ravimit oma kaksikule. Selle nimi on 'Calvan'");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("*Apteeker:* Oiii! See on ju väga kange rohi, kas teie kaksik on haige? Vaeseke! Teen teile allahindlust, kuid pean ikkagi küsima rohu eest 20 eurot.");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("Muidugi, kohe otsin... *Haarab rahakoti järele*");
            Console.ReadKey();
            Console.WriteLine("Issake, see on kadunud! Viimati kasutasin seda lennujaamas... Pidin selle vist seal maha pillama. Andestage mulle.");
            Console.ReadKey();
            Console.WriteLine("*Mida ma küll edasi teen...*");
            Console.ReadKey();
            valik6:
            Console.WriteLine("'küsin nõu' või 'lähen ära'");
            Console.Clear();
            while (true)
            {
                
                var valik6 = Console.ReadLine().ToLower();
                if (valik6 == "küsin nõu")
                {
                    Console.WriteLine("Kas te oskate mulle nõu anda, mida ma tegema peaksin?");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Apteeker:* Politseilt pole teil mõtet nõu küsida. Nad on liiga aeglased. Kuid minge vaadake tänaval ringi, minu teada on Anni poe omanikul praegu abikäsi vaja, ehk saate raha teenida.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.WriteLine("Aitäh! Kust ma ta leida võiks?");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Apteeker:* Te peate minema siit paremale ja siis otse edasi, kuni näete suurt lilledega kaunistatud maja.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.WriteLine("Aitäh! Näeme veel!");
                    Console.ReadKey();
                    Console.WriteLine("*Mõnda aega kõndides jõuangi lilledega kaunistatud poeni. Astun sisse.*");
                    Console.ReadKey();
                }
                else if (valik6 == "lähen ära")
                {
                    Console.WriteLine("*Kõnnin aeglaselt apteekist välja* Nüüd pean mõtlema, mis edasi teha.");
                    Console.ReadKey();
                    Console.WriteLine("See naine tee peal tundub olevat arukas. Küsin temalt nõu.");
                    Console.ReadKey();
                    Console.WriteLine("Tere! Kas saaksite mind aidata? Mul on vaja osta oma kaksikule elutähtis ravim, kuid ma kaotasin oma rahakoti ära.");
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("*Naine:* Mina teid kahjuks rahaga aidata ei saa, kuid siit veidi edasi on üks pood. Ma tean, et omanik on rottidega hädas ning kui te teda aitate, siis ehk ta maksab teile.");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.WriteLine("Suur tänu teile!");
                    Console.ReadKey();
                    Console.WriteLine("*Varsti näengi poodi.*");
                    Console.ReadKey();
                    string poodv = System.IO.File.ReadAllText(@"..\..\info\poodv.txt");
                    Console.WriteLine(poodv);
                    Console.WriteLine("*Astun sisse.*");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    continue;
                }

            }
            
        }
    }
}
