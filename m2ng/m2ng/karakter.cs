using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2ng
{
    class karakter
    {
        public karakter()
        {
            HP = 100;
            EnemyHP = 40;
        }
        public string nimi { get; set; }
        public int vanus { get; set; }
        public string sugu { get; set; }
        public static int stamina { get; set; }
        public static int HP { get; set; }
        public static int EnemyHP { get; set; }

        public static string path1 = @"../../../Stamina.txt";

    }
}

