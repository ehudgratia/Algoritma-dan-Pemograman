using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Task_8
    {
        struct Nilai
        {
            public int tugas;
            public int UTS;
            public int UAS;
            public double akhir;
        }
        struct Mahasiswa
        {
            public string NIM, nama;
            public Nilai teori;
            public Nilai praktek;
            public double final;
        }

        static void Main(string[] args)
        {
            Console.Title = "Nilai Mahasiswa";
            Mahasiswa mhs = new Mahasiswa();
            Console.Write("Masukan NIM          : ");
            mhs.NIM = Console.ReadLine();
            Console.Write("Masukan Nama         : ");
            mhs.nama = Console.ReadLine();

            Console.Write("Masukan Nilai Tugas Teori  : ");
            mhs.teori.tugas = int.Parse(Console.ReadLine());
            Console.Write("Masukan Nilai UTS Teori  : ");
            mhs.teori.UTS = int.Parse(Console.ReadLine());
            Console.Write("Masukan Nilai UAS Teori  : ");
            mhs.teori.UAS = int.Parse(Console.ReadLine());

            Console.Write("Masukan Nilai Tugas Praktek  : ");
            mhs.praktek.tugas = int.Parse(Console.ReadLine());
            Console.Write("Masukan Nilai UTS Praktek  : ");
            mhs.praktek.UTS = int.Parse(Console.ReadLine());
            Console.Write("Masukan Nilai UAS Praktek  : ");
            mhs.praktek.UAS = int.Parse(Console.ReadLine());

            //nilai akhir teori
            mhs.teori.akhir = 0.2 * mhs.teori.tugas + 0.3 * mhs.teori.UTS + 0.5 * mhs.teori.UAS;

            //nilai akhir praktek
            mhs.teori.akhir = 0.2 * mhs.teori.tugas + 0.3 * mhs.teori.UTS + 0.5 * mhs.teori.UAS;

            //nilai akhir final
            mhs.final = 0.5 * mhs.teori.akhir + 0.5 * mhs.praktek.akhir;

            Console.Clear();
            Console.WriteLine("NIM  : " + mhs.NIM);
            Console.WriteLine("Nama : " + mhs.nama);
            Console.WriteLine();
            Console.WriteLine("Nilai Teori");
            Console.WriteLine("\tTugas      : " + mhs.teori.tugas );
            Console.WriteLine("\tUTS        : " + mhs.teori.UTS);
            Console.WriteLine("\tUAS        : " + mhs.teori.UAS);
            Console.WriteLine();
            Console.WriteLine("Nilai Praktek");
            Console.WriteLine("\tTugas      : " + mhs.praktek.tugas);
            Console.WriteLine("\tUTS        : " + mhs.praktek.UTS);
            Console.WriteLine("\tUAS        : " + mhs.praktek.UAS);
            Console.WriteLine();
            Console.WriteLine("Nilai Akhir");
            Console.WriteLine("\tTeori      : " + mhs.teori.akhir);
            Console.WriteLine("\tPraktek    : " + mhs.praktek.akhir);
            Console.WriteLine("\tFinal      : " + +mhs.final);

            Console.ReadKey();
        }
    }
}
