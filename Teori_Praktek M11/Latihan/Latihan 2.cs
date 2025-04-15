using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Latihan_2
    {
        public static int LuasPersegiPanjang(int panjang, int lebar)
        {
            int luas = panjang * lebar;
            return luas;

        }
        static void Main(string[] args)
        {
            Console.Title = "Luas Persegi Panjang";
            int panjang, lebar;
            Console.Write("Masukan Panjang : ");
            panjang = int.Parse(Console.ReadLine());
            Console.Write("Masukan Lebar : ");
            lebar = int.Parse(Console.ReadLine());

            Console.WriteLine("Luas persegi panjang = " + LuasPersegiPanjang(panjang, lebar));
            Console.ReadKey();
        }
    }
}
