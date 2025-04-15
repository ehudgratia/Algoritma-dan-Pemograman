using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class PhotoTOPrint
    {
        public string pemilikFoto, pemotret, jenisCetak;
        public int lebar, tinggi, cetak, harga;
    }
    class Program
    {
        static void Frame()
        {
            Console.WriteLine(new string('^', 50));
        }


        static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Pilihan Cetak");
            Console.WriteLine("1. Hitam-Putih");
            Console.WriteLine("2. Warna");
            Console.WriteLine();
        }
        static void Main()
        {
            Console.Title = "Lisa Photo";
            PhotoTOPrint PTP = new PhotoTOPrint();
            Console.Write("Masukan Pemilik Foto : ");
            PTP.pemilikFoto = Console.ReadLine();
            Console.Write("Masukan Pemotret : ");
            PTP.pemotret = Console.ReadLine();
            Console.Write("Masukan Lebar Foto : ");
            PTP.lebar = int.Parse(Console.ReadLine());
            Console.Write("Masukan Tinggi Foto : ");
            PTP.tinggi = int.Parse(Console.ReadLine());
            Menu();
            Console.Write("Masukan Pilihan Cetak Foto : ");
            PTP.cetak = int.Parse(Console.ReadLine());

            switch (PTP.cetak)
            {
                case 1:
                    PTP.jenisCetak = "Hitam-Putih";
                    break;
                case 2:
                    PTP.jenisCetak = "Putih";
                    break;
            }

            Console.Write("Tentukan Harga Cetak Foto : ");
            PTP.harga = int.Parse(Console.ReadLine());
            Console.Clear();
            Frame();
            Console.WriteLine("Pemilik foto " + PTP.pemilikFoto);
            Console.WriteLine("Pemotret Object " + PTP.pemotret);
            Console.WriteLine($"Resolusi foto : Lebar {PTP.lebar} - tinggi {PTP.tinggi}");
            Console.WriteLine("Jenis Cetak foto " + PTP.jenisCetak);
            Console.WriteLine("Harga Cetak foto " + PTP.harga.ToString("#,##0"));
            Frame();

            Console.ReadKey();

        }
    }
}
