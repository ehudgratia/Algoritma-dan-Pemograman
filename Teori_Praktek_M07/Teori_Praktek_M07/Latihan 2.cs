using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teroi_Praktek_M07
{
    class Latihan_2
    {
        static void Main(string[] args)
        {
            Console.Title = "Perkalian";

            int n, i, j;
            Console.Write("Masukan n : ");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    Console.Write($"{j} x {i} = {j * i}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
