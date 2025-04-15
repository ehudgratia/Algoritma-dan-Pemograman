using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Class5
    {
        static void Main(string[] args)
        {
            int nilai = 100;
            do
            {
                Console.WriteLine(nilai);
                nilai -= 1;
            } while (nilai >= 1);
            Console.ReadKey();
        }
    }
}
