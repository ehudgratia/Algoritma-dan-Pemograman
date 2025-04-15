using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Latihan_1_2
    {
        static void Main(string[] args)
        {
            Console.Title = "Rectangular Array";
            string[,] rect = { {"Baju", "Celana"}, { "Sendok", "Garpu" }, { "Amplop", "Perangko" } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(rect[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
