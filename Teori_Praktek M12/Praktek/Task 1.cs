using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class Task_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Daftar Nama";



            int n;
            Console.Write("Masukkan jumlah orang : ");
            n = int.Parse(Console.ReadLine());



            string[] nama = new string[n]; //jumlah elemen dari array nama berdasarkan jumlah n



            for (int i = 0; i < n; i++)
            {
                Console.Write("Masukkan nama ke-{0} : ", i + 1);
                nama[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine(new string(' ', 15) + "DAFTAR NAMA"); //40 - 11 = 29 / 2 = 15
            Console.WriteLine(new string('=', 40));
            for (int i = 0; i < n; i++)
            {
                Array.Sort(nama, StringComparer.InvariantCulture);
                Console.WriteLine("{0}. {1}", i + 1, nama[i]); //i + 1 = 0 + 1 = 1. Setiap melakukan, akan dicek sampai batas yang ditentukan. Misal i < n, anggap n = 5. i + 1 = 0 + 1 //0 + 1 = 1, 1 + 1 = 2, 2 + 1 = 3, 3 + 1 = 4, 4 + 1 = 5. -------- nama[i], nama[0] = inputan 1 s.d. nama[i < n]
            }
            Console.ReadKey();
        }

    }
}
