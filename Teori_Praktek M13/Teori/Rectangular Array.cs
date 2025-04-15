using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Rectangular_Array
    {
        static void Main(string[] args)
        {
            Console.Title = "Rectangular Array";
            int[,] rect = { { , 4, 6, 8 }, { 5, 10, 15, 20 }, { 7, 14, 21, 28 } };
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
