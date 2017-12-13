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
            Console.WriteLine("Ohoh! Seal ongi üks koristaja! Tema tunneb kindlasti seda linna!");
            Console.WriteLine("Tere! Kas te oskate mind aidata?");
            Console.WriteLine("*Koristaja*: Tere, milles on probleem?");
            Console.WriteLine("Olen siin linnas esimest korda ja sooviksin minna lähimasse apteeki. Kas te oskate mind juhatada?");
            Console.WriteLine("*Koristaja*: Muidugi! Kõige lähemal asub arvatavasti Lare'i apteek. Kas ma seletan teile või annan teile linnakaardi? Kaardi eest peaksite aga maksma 50 senti, sest see on kahjuks minu viimane ja mul pole hetkel võimalik uut ostma minna.");
            Console.WriteLine("*Hmm... Haarab rahakoti järgi...*");
            Console.WriteLine("*Linnakaardi ostmiseks vajutage l ja seletuse jaoks s*");
            var valik = Console.ReadLine();

            if (valik == "l")
            {
                Console.WriteLine("Kaart oleks vist parem variant. *Naeran*: Mulle ei jää asjad hästi meelde.");
                Console.WriteLine("*Koristaja:* Arusaadav, näe, ole aga lahke!");
                Console.WriteLine("Tänan. *Maksan raha* Head päeva jätku!");
                Console.WriteLine("*Kõndides vaatan kaarti ja mõtlen:* Siin on ju nii segased joonised ja tekst kõik võõrkeeles! Sellest ma küll midagi aru ei saa! Aga pole hullu, küsin siis linnaelanikelt.");
            }
            if (valik == "s")
            {
                Console.WriteLine("Teate, ma kaarte hästi ei mõista. Sooviksin vist seletust.");
                Console.WriteLine("*Koristaja:* Arusaadav! Te peate lihtsalt kõndima lennujaamast välja suure rohelise hooneni ja keerama sealt vasakule. Siis näete suurt puud, minge paremale, peale seda uuesti paremale ning teeristile jõudes vasakule. Siis näete suurt kaubahoonet ja sealt otse edasi minnes jõuategi apteeki. Mõistate?");
                Console.WriteLine("*Segaduses*: Ahah... Vist küll, suur tänu teile!");
                Console.WriteLine("*Endamisi mõeldes*: Sellest ma küll midagi aru ei saanud, kuid parem ei hakka naist rohkem tüütama. Uurin parem linlastelt!");
            }
            Console.WriteLine("*Lahkun aeglaselt.* Tegelikult ma ei usu, et see nii keeruline saab olla. Kindlasti olen juba poole tunni pärast haiglas!");

            //Linna jõudes
            Console.WriteLine("Hmm, milline ilus linn. Nüüd tuleb vaid otsida inimesi, kes mind apteeki juhatada oskaks.")
;           Console.WriteLine("*Näha on üks lonkav vanainimene.* Kas 'kõnnin mööda' või 'küsin abi'?");
            var valik2 = Console.ReadLine();

            if(valik2 == "kõnnin mööda")
            {
                Console.WriteLine("Hmm, ma ei usu, et tema mind aidata oskab. Vaatan edasi!");

            }
            if (valik2 == "küsin abi")
            {
                Console.WriteLine("Kuidas alustaksin vestlust? Kas:");
                Console.WriteLine("1: Tervist, vanaproua, kas te aitaksite mind palun?");
                Console.WriteLine("2: Jou, kas aitad mind v?")
;               Console.WriteLine("3: Tere, kas te oskaksite mind palun edasi juhatada?");
                var valik3 = Console.ReadLine();

                if (valik3 == "1")
                {
                    Console.WriteLine("*Vanaproua*:Oi, pojuke, mis vanaproua mina olen, mina pole veel abieluski, mina veel alles preili!");
                    Console.WriteLine("Mida vastan?");
                    Console.WriteLine("a: Ah, mis sa ajad, sa ju vana nagu muld!");
                    Console.WriteLine("b: Vabandust, oleksin pidanud kohe aru saama!");
                    var val = Console.ReadLine();
                    if (val == "a")
                    {
                        Console.WriteLine("*Vanaproua:* Kuidas palun!? Kao mu silmist!");
                        Console.WriteLine("*Kõnnin lihtsalt edasi. Kuskil peab ju keegi mind ikka aitama.*");
                        Console.ReadLine();
                    }
                    if (val == "b")
                    {
                        Console.WriteLine("*Vanaproua*: Ah, pole hullu, ma niisama! Kuhu sul minna on vaja?");
                        Console.WriteLine("Ma sooviksin minna Lare'i apteeki. Kuhu ma minema pean?");
                        Console.WriteLine("*Vanaproua:* Oii, seda kohta mina tean! Sealt ostan mina oma selja jaoks rohtu! Sa pead lihtsalt keerama siit vasakule, siis minema mööda teed paremale ja juba peaksidki nägema suurt maja, kus on APTEEK suurelt kirjas.");
                        Console.WriteLine("Aitäh! Head päeva! *Näen vanaproua kellalt, et kell on juba 13:50*");
                        Console.WriteLine("*Vanaproua:* Head päeva sullegi!");
                        Console.WriteLine("*Kõnnin vanaproua juhatatud teed pidi edasi*");
                        Console.ReadLine();
                    }
                }
                else if (valik3 == "2")
                {
                    Console.WriteLine("*Vanaproua:* Kuidas palun!? Kas sa saad, kao siit minema ja mine kooli keelt õppima! *Virutab vihmavarjuga*");
                    //VIHMAVARJUGA PIHTA SAAMINE VÄHENDAB STAMINAT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    Console.WriteLine("*Kõnnin lihtsalt edasi. Kuskile pean ju ikka välja jõudma.*");
                    Console.ReadLine();
                }
                else if (valik3 == "3")
                { 
                    Console.WriteLine("*Vanaproua*:Muidugi, lapsuke! Kuhu sul minna on vaja?");
                    Console.WriteLine("Mul oleks vaja minna Lare'i apteeki.");
                    Console.WriteLine("*Vanaproua*:Sa pead keerama siit vasakule, siis minema mööda teed paremale ja juba peaksidki nägema suurt maja, kus on APTEEK suurelt kirjas.");
                    Console.WriteLine("Selge! Aitäh teile! *Näeb vanaproua kellalt, et kell on 13:45* Pean nüüd kiirustama! Head päeva!");
                    Console.WriteLine("*Vanaproua*: Head päeva!");
                    Console.WriteLine("*Kõnnin vanaproua juhatatud teed pidi edasi*");
                    Console.ReadLine();
                }
             

                

            }
            



        }
}
}