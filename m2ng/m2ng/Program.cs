﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast '24 tundi'. Palun valige oma karakterile nimi.");
            karakter kasutaja = new karakter();
            kasutaja.nimi = Console.ReadLine();
            Console.WriteLine("Nüüd sisestage palun vanus.");
            kasutaja.vanus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis soost te olete?");
            kasutaja.sugu = Console.ReadLine();

            Console.WriteLine("*Raadio*: Tere hommikust, kell on 07:03. Tõuse ja sära!")
            Console.WriteLine()
        }
    }
}