using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Latihan_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Try...Catch";

            int n;

            int[] nilai = new int[10];

            InputN:
            try
            {
                Console.Clear();
                Console.Write("Masukan n : ");
                n = int.Parse(Console.ReadLine());
                try
                {
                    Console.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Masukan nilai ke-{0} : ", i + 1);
                        nilai[i] = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Nilai ke-{0} = {1}", i + 1, nilai[i]);
                        nilai[i] = int.Parse(Console.ReadLine());
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Nilai yang di-input harus menggunakan angka.");
                }
                catch (OutOfMemoryException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("n yang di-input harus menggunakan angka.");
                Console.ReadKey();
                goto InputN;
                
            }

            Console.ReadKey();
        }
    }
}
