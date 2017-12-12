using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class Program
    {
        public static string path;
        static void Main(string[] args)
        {
            path = @"../../../Invetory.txt";
            File.Delete(path);
            //Ärkamisest telefonikõnele vastamiseni
            // dialoog.Dialo();
            //Telefonikõnest külani
<<<<<<< HEAD
            // lennujaam.Lennujaam();

            TextFile majake = new TextFile(@"C:\code\Katrin\Tekstim2ng\m2ng\m2ng\info\ascii_maja.txt");
            Console.WriteLine(majake.getText());

            Console.ReadLine();

            
=======
            lennujaam.Lennujaam();
            //Koobas, hiljem storyga kokku sobitada. Lõpetada samuti ( võitlus ).
            //Koobas.Kooba();
>>>>>>> 412c3f991aff4b23d0ad37e4d2ee11f5677ab007
        }
    }
}
