using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class UnhandledException
    {
        static void Main(string[] args)
        {
            Console.Title = "Pembagian Bilangan";
            double bil1, bil2, bagi;
            Console.Write("Masukan bilangan 1\t: ");
            bil1 = double.Parse(Console.ReadLine());
            Console.Write("Masukan bilangan 2\t: ");
            bil2 = double.Parse(Console.ReadLine());
            bagi = bil1 / bil2;
            Console.WriteLine("Hasil pembagian\t= {0}", bagi);
            Console.ReadKey();
        }
    }
}