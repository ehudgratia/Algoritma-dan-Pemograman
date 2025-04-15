using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Class8_While
    {
        static void Main(string[] args)
        {
            int i = 101;
            while (i <= 100)
            {
                Console.WriteLine(i);
                i += 1;
            }
            Console.ReadKey();
        }
    }
}
