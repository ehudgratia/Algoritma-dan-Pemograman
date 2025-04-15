using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Latihan_1_4
    {
        static void Main(string[] args)
        {
            Console.Title = "Jagged Array";
            double[][] jagged = { new double[] { 0.1, 2.4, 4.7, 6.9, 8.5 },
                               new double[] {3.8, 6.5, 9.3},
                               new double[] { 7.2, 6.0, 5.1, 4.4, 3.6, 1.2 } };
            foreach (var row in jagged)
            {
                foreach (var element in row)
                {
                    Console.Write(element + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
