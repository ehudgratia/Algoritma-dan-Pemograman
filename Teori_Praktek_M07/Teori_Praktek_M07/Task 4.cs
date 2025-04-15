using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teroi_Praktek_M07
{
    class Task_4
    {
        static void Main(string[] args)
        {
            Console.Title = "Bilangan Pecahan";
            int bil, i, a;

            Console.Write("Masukan Bilangan : ");
            bil = int.Parse(Console.ReadLine());

            for (i = 1; i <= bil; i++)
            {
                Console.Write(i + "/");
                a = i + 1;
                Console.Write(a + "\t");
            }

            Console.ReadKey();
        }
    }
}
