using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class Task_5
    {
        static void Main(string[] args)
        {
            Console.Title = "Pola Bintang";

            int n;
            char karakter;

            Console.Write("Masukan NIM : ");
            n = int.Parse(Console.ReadLine());

            int[] data = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Angka ke- {0} : ", i + 1);
                data[i] = int.Parse(Console.ReadLine());
            }

            //Console.Write("Masukan karakter : ");
            //karakter = char.Parse(Console.ReadLine());
            //Console.Clear();

            //Console.WriteLine("Data\tNilai");
            //Console.WriteLine(new string('=', 25));

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("{0} : {1} ", angka[i], new string(karakter, angka[i])); //Console.WriteLine(angka[i] + " : " + new string(karakter, angka[i]));
            //}

            Console.ReadKey();
        }
    }
}
