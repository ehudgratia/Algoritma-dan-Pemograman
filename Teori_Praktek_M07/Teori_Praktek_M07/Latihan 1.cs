using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teroi_Praktek_M07
{
    class Latihan_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Deret Bilangan";

            int n, i, total=0;
            Console.Write("Masukan n : ");
            n = int.Parse(Console.ReadLine());

            for(i=1; i <= n; i += 1)
            {
                if (i == n)
                {
                    Console.Write(i + " = ");

                }
                else
                {
                    Console.Write(i + " + ");
                }
                total += i;
            }
            Console.Write(total);
            Console.ReadKey();
        }
    }
}
