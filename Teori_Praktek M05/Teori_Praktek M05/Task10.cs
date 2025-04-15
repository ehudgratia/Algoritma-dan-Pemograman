using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class Task10
    {
        static void Main(string[] args)
        {
            Console.Title = "Angkatan dan Jurusan Mahasiswa";
            string nim, angkatan, namaJurusan;
            int kodeJurusan;

            Console.Write("Masukan NIM : ");
            nim = Console.ReadLine();

            angkatan = nim.Substring(0, 2);
            Console.WriteLine();
            Console.WriteLine("Angkatan: 20" + angkatan);

            kodeJurusan = int.Parse(nim.Substring(0, 3));
            switch (kodeJurusan)
            {
                case 111:
                    namaJurusan = "Teknik Informatika";
                    Console.WriteLine("Jurusan :" + namaJurusan);
                    break;
                case 211:
                    namaJurusan = "Sistem Informasi";
                    Console.WriteLine("Jurusan :" + namaJurusan);
                    break;
                case 021:
                    namaJurusan = "Manajemen Informatika";
                    Console.WriteLine("Jurusan :" + namaJurusan);
                    break;
                case 711:
                    namaJurusan = "Manajemen";
                    Console.WriteLine("Jurusan :" + namaJurusan);
                    break;
                case 811:
                    namaJurusan = "Akuntansi";
                    Console.WriteLine("Jurusan :" + namaJurusan);
                    break;
                default:
                    namaJurusan = "Tidak Terdaftar";
                    Console.WriteLine("Jurusan :" + namaJurusan);
                    break;

            }
            
            Console.ReadKey();
        }
    }
}
