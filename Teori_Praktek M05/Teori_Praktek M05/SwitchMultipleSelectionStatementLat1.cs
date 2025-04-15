using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class SwitchMultipleSelectionStatementLat1
    {
        static void Main(string[] args)
        {
            Console.Title = "Nama-nama Hari";
            int hari;

            Console.Write("Masukan nama Hari dari angka [1-7] : ");
            hari = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (hari)
            {
                case 1:
                    Console.WriteLine(" Hari Senin");
                    break;
                case 2:
                    Console.WriteLine("Hari Selasa");
                    break;
                case 3:
                    Console.WriteLine("Hari Rabu");
                    break;
                case 4:
                    Console.WriteLine("Hari Kamis");
                    break;
                case 5:
                    Console.WriteLine("Hari Jumat");
                    break;
                case 6:
                    Console.WriteLine("Hari Sabtu");
                    break;
                case 7:
                    Console.WriteLine("Hari Minggu");
                    break;
                default:
                    Console.WriteLine("Angka Hari Tidak Valid");
                    break;
            }
            Console.ReadLine();
        }
    }
}
