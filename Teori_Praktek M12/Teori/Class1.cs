using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.Title = "Array";
            int[] nilai = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Masukan nilai ke - {0} : ", i + 1);
                nilai[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for ( int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nilai ke-{0} = {1}", i + 1, nilai[i]);
            }
            Console.ReadKey();
        }
    }
}
