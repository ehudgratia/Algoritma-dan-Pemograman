using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] angka = { 7.2, 3.6, 8.9, 5.1, 4.7, 2.5 };
            for ( int i = 0; i<6; i++)
            {
                Console.WriteLine("Angka ke-{0} = {1}", i + 1, angka[i]);//angka[0}] = 7,2
            }
            Console.ReadKey();
        }
    }
}
