using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class NestedIfElseStatementLat1
    {
        static void Main(string[] args)
        {
            Console.Title = "Pembayaran";

            int jumlahbeli, jenisbayar, jeniskartu;
            double diskon = 0, jumlahbayar = 0;
            Console.Write("Masukkan Jumlah Pembelian : ");
            jumlahbeli = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Jenis Pembayaran [1.Cash 2.Kredit] : ");
            jenisbayar = int.Parse(Console.ReadLine());
            if (jenisbayar == 1)
            {
                diskon = 0.1d;
            }
            else if (jenisbayar == 2)
            {
                Console.Write("Masukkan Jenis Kartu Kredit [1. Master Card 2. Visa");
                jeniskartu = int.Parse(Console.ReadLine());
                if (jeniskartu == 1)
                {
                    diskon = 0.5d;
                }
                else if (jeniskartu == 2)
                {
                    diskon = 0.3d;
                }
                else
                {
                    Console.Write("Jenis Kartu Tidak Valid");
                }
            }
            else
            {
                Console.Write("Pembayaran Tidak Valid");
            }
            Console.WriteLine();
            jumlahbayar = jumlahbeli - (jumlahbeli * diskon);
            Console.WriteLine("Jumlah Pembelian  : " + jumlahbeli.ToString("Rp #,##0.00"));
            Console.WriteLine("Diskon            : " + diskon.ToString("P0"));
            Console.WriteLine("Jumlah Pembayaran : " + jumlahbayar.ToString("Rp #,##0.00"));

            Console.ReadKey();
        }
    }
}
