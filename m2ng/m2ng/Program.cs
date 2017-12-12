using System;
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
            //Ärkamisest telefonikõnele vastamiseni
            // dialoog.Dialo();
            //Telefonikõnest külani
            // lennujaam.Lennujaam();

            TextFile majake = new TextFile(@"C:\code\Katrin\Tekstim2ng\m2ng\m2ng\info\ascii_maja.txt");
            Console.WriteLine(majake.getText());

            Console.ReadLine();

            
        }
    }
}
