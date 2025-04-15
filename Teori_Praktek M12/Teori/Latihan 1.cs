using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Latihan_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Data Mahasiswa";

            int n;

            Console.Write("Masukan n : ");
            n = int.Parse(Console.ReadLine());

            String[] nim = new string[n];
            String[] nama = new string[n];
            DateTime[] tanggalLahir    = new DateTime[n];
            String[] alamat = new string[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.Write("Masukan NIM Mahasiswa ke {0} : ", i + 1);
                nim[i] = Console.ReadLine();
                Console.Write("Masukan Nama Mahasiswa ke {0} : ", i + 1);
                nama[i] = Console.ReadLine();
                Console.Write("Masukan Tanggal lahir Mahasiswa ke {0} : ", i + 1);
                tanggalLahir[i] = DateTime.Parse(Console.ReadLine());
                Console.Write("Masukan Alamat mahasiswa ke {0} : ", i + 1);
                alamat[i] = Console.ReadLine();
            }

            Console.Clear();
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("NIM Mahasiswa                ke-{0} = {1}", i + 1, nim[i]);
                Console.WriteLine("Nama Mahasiswa               ke-{0} = {1}", i + 1, nama[i]);
                Console.WriteLine("Tanggal lahir Mahasiswa      ke-{0} = {1}", i + 1, tanggalLahir[i].ToString("dd MMMM yyyy"));
                Console.WriteLine("Alamat Mahasiswa             ke-{0} = {1}", i + 1, alamat[i]);
                Console.WriteLine();
            }





            Console.ReadKey();
        }
    }
}
