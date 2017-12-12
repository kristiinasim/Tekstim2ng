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
            dialoog.Dialo();
            //Telefonikõnest külani
            lennujaam.Lennujaam();
            //Koobas, hiljem storyga kokku sobitada. Lõpetada samuti ( võitlus ).
            //Koobas.Kooba();
        }
    }
}
