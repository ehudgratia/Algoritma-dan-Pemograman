using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Latihan_3
    {
        static int panjang, lebar;
        public static double LuasPersegiPanjang(int panjang, int lebar)
        {
            double luas = panjang * lebar;
            return luas;
        }

        public static double KelilingPersegiPanjang(int panjang, int lebar)
        {
            double keliling = 2 * (panjang + lebar);
            return keliling;
        }

        public static double DiagonalPersegiPanjang(int panjang, int lebar)
        {
            double diagonal = (panjang * panjang) + (lebar * lebar);
            return diagonal;
        }

        static void InputPilihanMenu()
        {
            Console.Clear();
            int panjang, lebar;
            Console.Write("Masukkan Panjang : ");
            panjang = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Lebar   : ");
            lebar = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.Title = "Luas Persegi Panjang";

        menuutama:
            int menu;
            Console.Clear();
            Console.WriteLine(new string(' ', 18) + "MENU"); // 40 - 14 = 36 / 2 = 18
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Luas Keliling Persegi Panjang");
            Console.WriteLine("3. Luas Diagonal Persegi Panjang");
            Console.WriteLine(new string('=', 40));
            Console.Write("Masukkan Kode [1/2/3] : ");
            menu = int.Parse(Console.ReadLine());
        InputMenu:
            if (menu == 1)
            {
                InputPilihanMenu();
                LuasPersegiPanjang(panjang, lebar);
                Console.WriteLine("Luas Persegi Panjang adalah " + panjang, lebar + LuasPersegiPanjang(panjang, lebar));
            }
            else if (menu == 2)
            {
                InputPilihanMenu();
                KelilingPersegiPanjang(panjang, lebar);
                Console.WriteLine("Luas Keliling Persegi Panjang adalah " + KelilingPersegiPanjang(panjang, lebar));
            }
            else if (menu == 3)
            {
                InputPilihanMenu();
                DiagonalPersegiPanjang(panjang, lebar);
                Console.WriteLine("Luas Diagonal Persegi Panjang adalah " + DiagonalPersegiPanjang(panjang, lebar));
            }
            else
            {
                Console.WriteLine("Menu yang anda masukkan tidak valid!!");
                goto InputMenu;
            }
            Console.ReadKey();
            goto menuutama;
        }
    }
}
