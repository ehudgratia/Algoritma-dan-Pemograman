using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teroi_Praktek_M07
{
    class Task_6
    {
        static void Main(string[] args)
        {
            Console.Title = "Pola Bilangan";

            int pilihan, nilai,i;

            inputulang:
            Console.WriteLine(new string(' ', 15) + "Pola Bilangan");
            Console.WriteLine(new string('=', 45));
            Console.WriteLine("1. Pola Segitiga");
            Console.WriteLine("2. Pola Persegi");
            Console.WriteLine("3. Pola Persegi Panjang");
            Console.WriteLine("4. Pola Fibonacci");
            Console.WriteLine("5. Keluar");
            Console.WriteLine(new string('=', 45));
            Console.Write("Masukkan pilihan : ");
            pilihan = int.Parse(Console.ReadLine());
            if (pilihan == 1)
            {
                Console.Clear();
                Console.WriteLine(new string(' ', 15) + "Pola Segitiga");
                Console.WriteLine(new string('=', 45));
                Console.Write("Masukan nilai : ");
                nilai = int.Parse(Console.ReadLine());
                for (i = 1; i <= nilai; i++)
                {
                    Console.Write(i * (i + 1) / 2 + "\t");
                }
            }
            else if (pilihan == 2)
            {
                Console.Clear();
                Console.WriteLine(new string(' ', 15) + "Pola Persegi");
                Console.WriteLine(new string('=', 45));
                Console.Write("Masukan nilai : ");
                nilai = int.Parse(Console.ReadLine());
                for (i = 1; i <= nilai; i++)
                {
                    Console.Write(i * i + "\t");
                }
            }
            else if (pilihan == 3)
            {
                Console.Clear();
                Console.WriteLine(new string(' ', 10) + "Pola Persegi Panjang");
                Console.WriteLine(new string('=', 45));
                Console.Write("Masukan nilai : ");
                nilai = int.Parse(Console.ReadLine());
                for (i = 1; i <= nilai; i++)
                {
                    Console.Write(i * (i + 1) + "\t");
                }
            }
            else if (pilihan == 4)
            {
                ulang:
                Console.Clear();
                Console.WriteLine(new string(' ', 15) + "Pola Fibonacci");
                Console.WriteLine(new string('=', 45));
                Console.Write("Masukan nilai (min 3) : ");
                nilai = int.Parse(Console.ReadLine());
                if (nilai <= 2)
                {
                    Console.WriteLine("Nilai minimal 3.");
                    Console.ReadKey();
                    goto ulang;

                }
                else
                {
                    int x = 0, y = 1, z = 1;
                    for (i = 1; i <= nilai; i++)
                    {
                        Console.Write(z + "\t");
                        z = x + y;
                        x = y;
                        y = z;

                    }
                }
                
            }
            else if (pilihan == 5)
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Pilihan tidak tersedia");
                Console.ReadKey();
                Console.Clear();
                goto inputulang;
            }

            Console.ReadKey();
        }
    }
}
