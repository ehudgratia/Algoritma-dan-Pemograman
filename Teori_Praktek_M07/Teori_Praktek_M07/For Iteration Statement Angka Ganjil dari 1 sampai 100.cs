using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teroi_Praktek_M07
{
    class For_Iteration_Statement_Angka_Ganjil_dari_1_sampai_100
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
