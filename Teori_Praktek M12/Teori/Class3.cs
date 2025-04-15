using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Class3
    {
        static void Main(string[] args)
        {
            Console.Title = "Array";
            int n, total;
            double rata;
            Console.Write("Masukan n : ");
            n = int.Parse(Console.ReadLine());
            int[] nilai = new int[n];
            total = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Masukan nilai ke - {0} : ", i + 1);
                nilai[i] = int.Parse(Console.ReadLine());
                total = total + nilai[i];
            }
            rata = (double)total / n;
            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nilai ke-{0} = {1}", i + 1, nilai[1]);
            }
            Console.WriteLine("Total = " + total);
            Console.WriteLine("Rata-rata = " + rata.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
