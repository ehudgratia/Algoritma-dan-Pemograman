using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teroi_Praktek_M07
{
    class For_Iteration_Statement_Infinite_Loop
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 100; i >= 1; i += 1) //Seharusnya i -= 1
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
