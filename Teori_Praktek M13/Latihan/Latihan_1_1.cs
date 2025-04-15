using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class latihan_1_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Rectangular Array";
            int[,] rect = { { 30, 40, 50, 30, 40, 50 } };
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(rect[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
