using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class Task_2
    {
        static void Main(string[] args)
        {
            Console.Title = "Pola";

            int n;
            char karakter;

            Console.Write("MAsukan jumlah Angka : ");
            n = int.Parse(Console.ReadLine());

            int[] angka = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Angka ke- {0} : ", i + 1);
                angka[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Masukan karakter : ");
            karakter = char.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} : {1} ", angka[i], new string(karakter, angka[i])); //Console.WriteLine(angka[i] + " : " + new string(karakter, angka[i]));
            }

            Console.ReadKey();
        }
    }
}
