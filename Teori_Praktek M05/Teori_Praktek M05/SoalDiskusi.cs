using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class SoalDiskusi
    {
        static void Main(string[] args)
        {
            Console.Title = "Nama Hewan";
            int hewan;
            Console.Write("Masukan Jenis Hewan Sesuai Anggka [1/2/3] : ");
            hewan = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (hewan)
            {
                case 1:
                    Console.WriteLine("Gajah");
                    break;
                case 2:
                    Console.WriteLine("Singa");
                    break;
                case 3:
                    Console.WriteLine("Harimau");
                    break;
                default:
                    Console.WriteLine("Angka Tidak Valid");
                    break;
            }
            Console.ReadKey();
        }
    }
}
