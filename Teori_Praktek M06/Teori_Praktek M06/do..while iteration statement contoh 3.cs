using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Class6
    {
        static void Main(string[] args)
        {
            int nilai = 1;
            do
            {
                Console.WriteLine(nilai);
                nilai += 2;
            } while (nilai <= 100);
            Console.ReadKey();
        }
    }
}
