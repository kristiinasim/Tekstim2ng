using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Invetuur
    {
        public static string path;
        public static string Inv()
        {
            using (StreamReader sr = new StreamReader("../../../Invetory.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                return line;
            }
        }


        public static void Invcheck()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------------------");
            Console.WriteLine("Sinu seljakotis on: ");
            Invetuur.Inv();
            Console.WriteLine("----------------------------");
            Console.ResetColor();
        }

        public static void InvCommands()
        {
            path = @"../../../Invetory.txt";
            File.Delete(path);
            //Edasine ei ole tegelik osa koodist. Need on erinevad võimalused invetuuri kasutamiseks.
            //Neid siin hoides ei lähe need meelest.
            Console.WriteLine("Leiad maast veepudeli! 'korja üles' või 'jäta maha'");
            string veepu1 = Console.ReadLine();
            if (veepu1 == "korja üles")
            {
                string tekst = "\nveepudel";
                File.AppendAllText(path, tekst);
            }
            Console.WriteLine("Sinu seljakotis on nüüd: ");
            Invetuur.Inv();

            Console.WriteLine("sokolaad. 'korja üles' 'ei'");
            string soko = Console.ReadLine();
            if (soko == "korja üles")
            {
                string tekst2 = "\nsokolaad";
                File.AppendAllText(path, tekst2);
            }
            else if (soko == "ei")
            {
                Console.WriteLine("Jätad šokolaadi maha vedelema.");
            }
            Console.WriteLine("Sinu seljakotis on nüüd: ");
            Invetuur.Inv();

            Console.WriteLine("Stamina on otsakorral. Söö ära šokolaad? 'jah' või 'ei'");
            string s002ra = Console.ReadLine();
            if (s002ra == "jah")
            {
                string[] kontro = System.IO.File.ReadAllLines(path);
                foreach (string asi in kontro)
                {
                    if (asi == "sokolaad")
                    {
                        Console.WriteLine("*otsid kotist, leiad šokolaadi*: Nämm!");
                        string text = File.ReadAllText(path);
                        text = text.Replace("sokolaad", "---Tühi koht---");
                        File.WriteAllText(path, text);
                        Invetuur.Inv();
                    }
                    else if (asi != "sokolaad")
                    {
                        Console.WriteLine("*otsid kotist, leiad eseme*: Pole šokolaad..");
                    }
                }

            }
            else if (s002ra == "ei")
            {
                Console.WriteLine("Jätad šokolaadi söömata.");
            }
        }
    }
}
