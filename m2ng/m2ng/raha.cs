using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class raha
    {
        public const string FileName = @"C:..\..\info\raha.txt";

        public static float Saldo()
        {
            if (!File.Exists(FileName)) return 0.0F;
            string rida1 = File.ReadLines(FileName).First();
            // loe raha failist 1. realt summa ja taasta see
            float.TryParse(rida1, out float summa);
            return summa;
        }

        // summa märk määrab, kas lisada või vähendada
        public static bool Muuda(float summa)
        {
            float saldo = Saldo();
            // loe raha failist,

            if (summa < 0)
            {
                // kui negatiivne summa siis kontrolli, et failis oli suurem summa kui küsitakse.
                summa = Math.Abs(summa);
                if (summa > saldo) return false;
                saldo -= summa;
            }
            else
            {
                // kui positiivne siis lisa see juurde failis olevale summale.
                saldo += summa;
            }
            File.WriteAllText(FileName, saldo.ToString());

            return true;
        }
        
        // meetod: saldo():float - loeb failist summa
        // mmetod: muuda(float):bool - loeb summa ja muudab nii et summa ei läheks alla 0-i!
    }
}