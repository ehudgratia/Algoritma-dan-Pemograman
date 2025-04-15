using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class KuisPraktekM05
    {
        static void Main(string[] args)
        {
            Console.Title = ("[Praktek] Tes Formatif Minggu 05 - Ehud Gratia Manullang");

            string statusBekerja, statusSekolah;
            int umur, pendapatanPerbulan, jumlahTanggungan, biayaHidup;


            Console.Write("Masukkan umur : ");
            umur = int.Parse(Console.ReadLine());

            if (umur >= 18)
            {
                Console.Write("Masukkan status bekerja [Sudah/Belum] : ");
                statusBekerja = Console.ReadLine();
                if (statusBekerja == "Sudah")
                {
                    Console.Write("Masukkan pendapatan perbulan : ");
                    pendapatanPerbulan = int.Parse(Console.ReadLine());
                    Console.Write("Masukkan jumlah tanggungan : ");
                    jumlahTanggungan = int.Parse(Console.ReadLine());
                    biayaHidup = pendapatanPerbulan / jumlahTanggungan;
                    if (biayaHidup < 300000)
                    {
                        Console.Write("Penduduk Miskin");
                    }
                    else
                    {
                        Console.Write("Bukan Penduduk Miskin");
                    }

                }
                else
                {
                    Console.Write("Penduduk Miskin");
                }

            }
            else
            {
                Console.Write("Masukkan status sekolah [Masih Sekolah/Tidak Sekolah] : ");
                statusSekolah = Console.ReadLine();
                if (statusSekolah == "Masih Sekolah")
                {
                    Console.Write("Bukan Penduduk Miskin");
                }
                else
                {
                    Console.Write("Penduduk Miskin");
                }
            }

            Console.ReadKey();
        }
    }
}
