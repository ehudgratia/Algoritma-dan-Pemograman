using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teroi_Praktek_M07
{
    class Latihan_3a
    {
        static void Main(string[] args)
        {
            Console.Title = "Pola Bilangan";

            int n, i, j;
            Console.Write("Masukan n : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            //A
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.WriteLine();

            //B
            for (i = n; i >= 1; i--)
            {
                for (j = n; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.WriteLine();

            //E
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.WriteLine();


            //F
            for (i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
