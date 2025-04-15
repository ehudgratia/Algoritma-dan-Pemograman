using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Latihan_1_3
    {
        static void Main(string[] args)
        {
            Console.Title = "Rectangular Array";
            char[,] rect = { { 'Z','x','C','V','B','N'}, { 'A','s','D','F','G','H'}, { 'q','W','e','R','t', 'Y'} };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(rect[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
