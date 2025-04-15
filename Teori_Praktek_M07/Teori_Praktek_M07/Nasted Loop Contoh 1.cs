using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teroi_Praktek_M07
{
    class Nasted_Loop_Contoh_1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\t");
            }
            Console.ReadKey();
        }
    }
}
