using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Latihan_4
    {
        static int sisi, panjang, lebar, alas, tinggi;
        public static int LuasPersegi(int sisi)
        {
            int luas = sisi * sisi;
            return luas;
        }
        static void InputSisiPersegi()
        {
            Console.Write("Masukan Sisi : ");
            sisi = int.Parse(Console.ReadLine());
        }

        public static int LuasPersegiPanjang(int panjang, int lebar)
        {
            int luas = panjang * lebar;
            return luas;
        }
        static void InputSisiPersegiPanjang()
        {
            Console.Write("Masukan Panjang  : ");
            panjang = int.Parse(Console.ReadLine());
            Console.Write("Masukan Lebar    : ");
            lebar = int.Parse(Console.ReadLine());
        }

        public static int LuasSegitiga(int alas, int tinggi)
        {
            int luas = alas * tinggi / 2 ;
            return luas;
        }
        static void InputSegitiga()
        {
            Console.Write("Masukan Alas     : ");
            alas = int.Parse(Console.ReadLine());
            Console.Write("Masukan tinggi   : ");
            tinggi = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.Title = "Luas Bangun Datar";
            int pilihan;
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Luas Bangun Datar");
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine(new string('=', 40));
        Pilihan:
            Console.Write("Masukan pilihan Anda [1/2/3] : ");
            pilihan = int.Parse(Console.ReadLine());
            Console.Clear();

            if (pilihan == 1)
            {
                Console.Title = "Luas Persegi";
                Console.WriteLine("Luas Persegi");
                InputSisiPersegi();
                LuasPersegi(sisi);
                Console.WriteLine("Luas Persegi adalah " + LuasPersegi(sisi));
            }

            else if (pilihan == 2)
            {
                Console.Title = "Luas Persegi Panjang";
                Console.WriteLine("Luas Persegi Panjang");
                InputSisiPersegiPanjang();
                LuasPersegiPanjang(panjang, lebar);
                Console.WriteLine("Luas Persegi Panjang adalah " + LuasPersegiPanjang(panjang,lebar));
            }

            else if (pilihan == 3)
            {
                Console.Title = "Luas Segitiga";
                Console.WriteLine("Luas Segitiga");
                InputSegitiga();
                LuasSegitiga(alas, tinggi);
                Console.WriteLine("Luas Segitiga adalah " + LuasSegitiga(alas, tinggi));
            }
            else
            {
                Console.WriteLine("Pilihan anda tidak valid, coba ulang!");
                goto Pilihan;
            }

            
            Console.ReadKey();
        }
    }
}
