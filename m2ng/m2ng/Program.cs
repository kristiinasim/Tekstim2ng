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
            //ASCII
            string pilt = System.IO.File.ReadAllText(@"C:\Users\opilane\Documents\GitHub\Tekstim2ng\pilt.txt");
            Console.WriteLine(pilt);
            //Ärkamisest telefonikõnele vastamiseni
            dialoog.Dialo();
            //Telefonikõnest külani
            lennujaam.Lennujaam();
            //Lennujaamas sees ning linnas:
            linna.linnas();
            //Linnas. Alates teisest karakterist.
            linnas.linn();
            

        }

        
    }
}
