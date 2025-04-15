using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class NestedIfElseStatementLat2
    {
        static void Main(string[] args)
        {
            String jurusan, waktuKuliah="";
            int biaya=0;
            char waktu;
            Console.Title = "Biaya Kuliah Mahasiswa";
            Console.Write("Nama Jurusan\t   : ");
            jurusan = Console.ReadLine();
            if (jurusan == "Teknik Informatika")
            {
                Console.Write("Waktu Kuliah [P/S] : ");
                waktu = char.Parse(Console.ReadLine());
                if (waktu == 'P')
                {
                    waktuKuliah = "Pagi";
                    biaya = 10000000;
                }
                else
                {
                    waktuKuliah = "Sore";
                    biaya = 10500000;
                }
            }
            else if(jurusan == "Sistem Informasi")
            {
                Console.Write("Waktu Kuliah [P/S] : ");
                waktu = char.Parse(Console.ReadLine());
                if (waktu == 'P')
                {
                    waktuKuliah = "Pagi";
                    biaya = 10250000;
                }
                else
                {
                    waktuKuliah = "Sore";
                    biaya = 10750000;
                }
            }
            else if(jurusan == "Manajemen Informatika")
            {
                Console.Write("Waktu Kuliah [P/S] : ");
                waktu = char.Parse(Console.ReadLine());
                if (waktu == 'P')
                {
                    waktuKuliah = "Pagi";
                    biaya = 7500000;
                }
                else
                {
                    waktuKuliah = "Sore";
                    biaya = 8000000;
                }
            }
            else
            {
                Console.WriteLine("Data Anda tidak valid");
            }
            Console.WriteLine($"Biaya Kuliah {jurusan} ({waktuKuliah}) adalah {biaya.ToString("Rp #,##0.00")} ");
            Console.ReadKey();

        }
    }
}
