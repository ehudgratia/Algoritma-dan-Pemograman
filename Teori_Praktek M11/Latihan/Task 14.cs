using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Task_14
    {
        static void swap(ref int bil1, ref int bil2)
        {
            int bil3 = bil1;
            bil1 = bil2;
            bil2 = bil3;
          
        }
        static void Main()
        {
            Console.Title = "Tukar Angka";
            Console.Write("Masukkan Bilangan 1 : ");
            int bil1 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Bilangan 2 : ");
            int bil2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Sebelum Tukar : ");
            Console.WriteLine($"Bilangan 1 = {bil1}");
            Console.WriteLine($"Bilangan 2 = {bil2}");
            swap(ref bil1, ref bil2);
            Console.WriteLine();
            Console.WriteLine("Setelah Tukar : ");
            Console.WriteLine($"Bilangan 1 = {bil1}");
            Console.WriteLine($"Bilangan 2 = {bil2}");
            Console.ReadKey();
        }
    }
}
