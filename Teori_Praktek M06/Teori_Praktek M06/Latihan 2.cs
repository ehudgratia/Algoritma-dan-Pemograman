using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Latihan2
    {
        static void Main(string[] args)
        {
            int i = 1, batas;

            Console.Write("Masukan Batas : ");
            batas = int.Parse(Console.ReadLine());

            while (i <= batas )
            {
                Console.Write(i + "\t");
                i += 2;
            }
            Console.ReadKey();
        }
    }
}
