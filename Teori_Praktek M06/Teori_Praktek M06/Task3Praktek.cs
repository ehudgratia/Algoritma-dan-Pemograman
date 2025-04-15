using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Task3Praktek
    {
        static void Main(string[] args)
        {
            Console.Title = "Tebak Angka";

            int angka, tebakan;
            char jawab;

            do
            {
                Console.Clear();
                Console.Write("Masukan suatu angka : ");
                angka = int.Parse(Console.ReadLine());
                Console.Clear();
                do
                {
                    Console.Write("Masukan angka tebakan : ");
                    tebakan = int.Parse(Console.ReadLine());
                    if (angka > tebakan)
                    {
                        Console.WriteLine("Tebak angka lebih besar!");
                    }
                    else if (angka < tebakan)
                    {
                        Console.WriteLine("Tebak angka lebih kecil!");
                    }
                    else
                    {
                        Console.WriteLine("Angka Benar");
                    }
                } while (angka != tebakan);
                Console.WriteLine();
                Console.Write("Tekan Y jika ingin bermain lagi : ");
                jawab = char.Parse(Console.ReadLine());
            } while (jawab == 'Y' || jawab == 'y');

            

            Console.ReadKey();
        }
    }
}
