using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teroi_Praktek_M07
{
    class Task_8
    {
        static void Main(string[] args)
        {
            Console.Title = "Nested For";

            int nilai, i, j, angka=1;

            Console.Write("Masukan nilai : ");
            nilai = int.Parse(Console.ReadLine());

            for (i = 1; i <= nilai; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(angka + "\t");
                    angka++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
