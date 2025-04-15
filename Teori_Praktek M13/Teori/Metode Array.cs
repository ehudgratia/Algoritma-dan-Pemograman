using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Metode_Array
    {
        static void Main(string[] args)
        {
            Console.Title = "Metode Array";
            int n;
            double rata;
            Console.Write("Masukan n : ");
            n = int.Parse(Console.ReadLine());
            int[] nilai = new int[n];
            for (int i = 0; i <= nilai.GetUpperBound(0); i++)
            {
                Console.Write("Masukan nilai ke-{0} : ", i + 1);
                nilai[i] = int.Parse(Console.ReadLine());
            }
            rata = (double)nilai.Sum() / nilai.Length;
            Console.Clear();
            for (int i = 0; i < nilai.Length; i++)
            {
                Console.WriteLine("Nilai ke-{0} = {1}", i + 1, nilai[i]);
            }
            Console.WriteLine("Minimal\t= " + nilai.Min());
            Console.WriteLine("Maximal\t= " + nilai.Max());
            Console.WriteLine("Total\t\t= " + nilai.Sum());
            Console.WriteLine("Rata-rata\t\t= " + rata.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
