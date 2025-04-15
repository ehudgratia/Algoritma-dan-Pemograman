using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class NestedIfElseStatement
    {
        static void Main(string[] args)
        {
            Console.Title = "Klasifikasi Umur";
            int umur;
            Console.Write("Masukkan Umur Anda : ");
            umur = int.Parse(Console.ReadLine());
            if (umur >= 25)
            {
                if (umur > 50)
                {
                    Console.WriteLine("Masa Tua");
                }
                else
                {
                    Console.WriteLine("Masa Dewasa");

                }
            }
            else
            {
                if (umur >= 12)
                {
                    Console.WriteLine("Masa Remaja");
                }
                else
                {
                    Console.WriteLine("Masa Kanak-kanak");
                }
            }
            Console.ReadKey();

        }
    }
}
