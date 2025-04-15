using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Class7
    {
        static void Main(string[] args)
        {
            int i = 1, n;
            Console.Write("Masukan n : ");
            n = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(i);
                n += 1; // seharusnya i +=1. Miasl kita input nilai n = 5, i = 1 + 1 = 2. i = 2 + 1 = 3. seterusnya
            } while (i <= n);
            Console.ReadKey();
        }
    }
}
