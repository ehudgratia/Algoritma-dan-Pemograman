using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Class4
    {
        static void Main(string[] args)
        {
            int kelipatan, n, i = 1;

            Console.Write("Masukan kelipatan : ");
            kelipatan = int.Parse(Console.ReadLine());
            Console.Write("Masukan n : ");
            n = int.Parse(Console.ReadLine());
            do
            {
                Console.Write(kelipatan + "\t" );
                kelipatan += kelipatan;
            } while (kelipatan <= 100);
            Console.ReadKey();
        }
    }
}
