using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Exception_Built_in
    {
        static void Main(string[] args)
        {
            Console.Title = "Exception Built-in";
            int bil1, bil2, kali, bagi;
            try
            {
                Console.Write("Masukan bilangan 1\t: ");
                bil1 = int.Parse(Console.ReadLine());
                Console.Write("Masukan bilangan 2\t: ");
                bil2 = int.Parse(Console.ReadLine());
                kali = bil1 * bil2;
                bagi = bil1 / bil2;
                Console.WriteLine("Hasil perkalian = {0}", kali);
                Console.WriteLine("Hasil perkalian = {0}", bagi);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
