using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Class9_PostestLoop
    {
        static void Main(string[] args)
        {
            int i = 101;
            do
            {
                while (i <= 100)

                    Console.WriteLine(i);
                i += 1;
            } while (i <= 100);
            Console.ReadKey();
        }
    }
}
