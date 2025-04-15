using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Latihan3
    {
        static void Main(string[] args)
        {
            int i = 2, n;

            Console.Write("Masukan n : ");
            n = int.Parse(Console.ReadLine());
            
            

            while (i <= n)
            {
                Console.Write(i + "\t");
                i += 2;
            }
            Console.ReadKey();
        }
    }
}
