using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teroi_Praktek_M07
{
    class Interupsi_Perulangan_Goto
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    goto selesai;
                }
                Console.WriteLine(i);
            }
        selesai:
            Console.WriteLine("Selesai");
            Console.ReadKey();
        }
    }
}
