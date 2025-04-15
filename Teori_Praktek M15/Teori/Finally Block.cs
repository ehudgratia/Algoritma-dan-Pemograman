using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Finally_Block
    {
        static void Main(string[] args)
        {
            Console.Title = "Finally Block";
            int bil1, bil2, hasil = 0;
            try
            {
                Console.Write("Masukan bilangan 1\t: ");
                bil1 = int.Parse(Console.ReadLine());
                Console.Write("Masukan bilangan 2\t: ");
                bil2 = int.Parse(Console.ReadLine());
                hasil = bil1 / bil2;

            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Terjadi Kesalahan.");
            //}
            finally
            {
                Console.WriteLine("Hasil pembagian : {0}", hasil);
            }
            Console.ReadKey();

        }
    }
}
