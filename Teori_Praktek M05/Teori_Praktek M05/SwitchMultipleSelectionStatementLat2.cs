using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class SwitchMultipleSelectionStatementLat2
    {
        static void Main(string[] args)
        {
            Console.Title = "Nama-nama Bulan";
            int hari;

            Console.Write("Masukan nama Bulan dari angka [1-12] : ");
            hari = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (hari)
            {
                case 1:
                    Console.WriteLine("Bulan Januari");
                    break;
                case 2:
                    Console.WriteLine("Bulan Februari");
                    break;
                case 3:
                    Console.WriteLine("Bulan Maret");
                    break;
                case 4:
                    Console.WriteLine("Bulan April");
                    break;
                case 5:
                    Console.WriteLine("Bulan Mei");
                    break;
                case 6:
                    Console.WriteLine("Bulan Juni");
                    break;
                case 7:
                    Console.WriteLine("Bulan Juli");
                    break;
                case 8:
                    Console.WriteLine("Bulan Agustus");
                    break;
                case 9:
                    Console.WriteLine("Bulan September");
                    break;
                case 10:
                    Console.WriteLine("Bulan Oktober");
                    break;
                case 11:
                    Console.WriteLine("Bulan November");
                    break;
                case 12:
                    Console.WriteLine("Bulan Desember");
                    break;
                default:
                    Console.WriteLine("Angka Bulan Tidak Valid");
                    break;
            }
            Console.ReadLine();
        }
    }
}
