using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Jagged_Array
    {
        static void Main(string[] args)
        {
            Console.Title = "Jagged Array";
            int[][] jagged = { new int[] { 1, 2 },
                               new int[] {3},
                               new int[] { 4, 5, 6 } };
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
