using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Latihan_2_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Latihan 2_1";
            int[,,] rect = { { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } ,{ 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(rect[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
