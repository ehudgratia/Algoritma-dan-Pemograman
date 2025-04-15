using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class ConditionalOperator
    {
        static void Main(string[] args)
        {
            int nilai;
            Console.Write("Masukan Nilai : ");
            nilai = int.Parse(Console.ReadLine());

            Console.WriteLine(nilai >= 50 ? "Selamat Anda Lulus" : "Maaf Anda Gagal");

            Console.ReadKey();
        }
    }
}
