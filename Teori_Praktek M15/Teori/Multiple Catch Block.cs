using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Multiple_Catch_Block
    {
        static void Main(string[] args)
        {
            Console.Title = "Multiple Catch Block";
            int bil1, bil2;
            try
            {
                Console.Write("Masukan bilangan 1\t: ");
                bil1 = int.Parse(Console.ReadLine());
                Console.Write("Masukan bilangan 2\t: ");
                bil2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil pembagian : {0}", bil1 / bil2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Tidak boleh dibagi dengan 0.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi Kesalahan");
            }
            Console.ReadKey();
        }
    }
}
