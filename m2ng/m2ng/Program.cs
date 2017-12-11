using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace m2ng
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Application.Run(new Form1());
            //or -------------
            Form1 f = new Form1();
            f.Show();
            
           

            //C:\Users\opilane\Documents\GitHub\Tekstim2ng\m2ng\m2ng\Bitmap1.bmp
            Console.WriteLine("Tere tulemast '24 tundi'. Palun valige oma karakterile nimi.");
            karakter kasutaja = new karakter();
            kasutaja.nimi = Console.ReadLine();
            Console.WriteLine("Nüüd sisestage palun vanus.");
            kasutaja.vanus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis soost te olete?");
            kasutaja.sugu = Console.ReadLine();

            Console.WriteLine("*Raadio*: Tere hommikust, kell on 07:03. Tõuse ja sära!");
            Console.WriteLine("");
        }

        
    }
}
