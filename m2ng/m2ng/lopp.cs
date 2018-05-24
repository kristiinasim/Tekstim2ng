using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Lopp
    {
        /// <summary>
        /// Mängu lõpp.
        /// </summary>
        public static void Loppp()
        {
            Console.WriteLine("*Oot, kas see.. kas see on lennujaam???*");
            Console.ReadKey();
            Console.WriteLine("*Kõnnin lennujaama poole ja oi näe, minu rahakott!*");
            Console.ReadKey();
            Console.WriteLine("*Nüüd saan tõestada, et ma pole mu hull kaksik Alex Lee Epp.*");
            Console.ReadKey();
            Console.WriteLine("*Hakkan sammuma hullumaja poole.*");
            Console.ReadKey();
            Console.WriteLine("*Jõudsin ukse juurde ja astun uksest sisse.*");
            Console.ReadKey();
            Console.WriteLine("*Näen doktorit* : Mina pole mu kaksik Alex Lee Epp!" );
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Doktor: Tõesta et sa pole Epp!");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("*Näitan oma dokumenti*");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Doktor: Ma väga vabandan, et ajasin teid sassi.");
            Console.ResetColor();
            Console.ReadKey();
            Console.WriteLine("Pole midagi. Ikka juhtub.");
            Console.ReadKey();
            Console.WriteLine("Siin on ravimid, mida soovisite. Nägemist!");
            Console.ReadKey();
            Console.WriteLine("Sa oled edukalt mängu läbinud!");
            Karakter.Voitsid();
        }
    }
}
