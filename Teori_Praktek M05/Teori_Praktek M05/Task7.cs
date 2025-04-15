using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class Task7
    {
        static void Main(string[] args)
        {
            Console.Title = "Moon Cafe";

            int menu, ukuran=0, jumlah=0, harga=0, total=0;
            string namaMenu="", namaUkuran="";
            menu:
            Console.WriteLine(new string(' ', 13) + "MENU");
            Console.WriteLine(new string('=', 30));
            Console.WriteLine("1. Double Espresso");
            Console.WriteLine("2. Caramel Macchiato");
            Console.WriteLine("3. Chocolate Frappuccino");
            Console.WriteLine(new string('=', 30));
            Console.Write("Masukan menu [1/2/3]: ");
            menu = int.Parse(Console.ReadLine());
            if (menu == 1)
            {
                namaMenu = "Double Espresso";
                Console.Clear();
            ukuran1:
                Console.WriteLine(new string(' ', 13) + "UKURAN");
                Console.WriteLine(new string('=', 30));
                Console.WriteLine("1. Regular");
                Console.WriteLine("2. Tall");
                Console.WriteLine(new string('=', 30));
                Console.Write("Masukan ukuran [1/2]: ");
                ukuran = int.Parse(Console.ReadLine());
                if (ukuran == 1)
                {
                    namaUkuran = "Regular";
                    harga = 35000;
                    Console.Write("Masukan Jumlah: ");
                    jumlah = int.Parse(Console.ReadLine());

                }
                else if (ukuran == 2)
                {
                    namaUkuran = "Tall";
                    harga = 40000;
                    Console.Write("Masukan Jumlah: ");
                    jumlah = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ukuran tidak valid");
                    Console.ReadKey();
                    Console.Clear();
                    goto ukuran1;
                }
            }
            else if (menu == 2)
            {
                namaMenu = "Caramel Macchiato";
                Console.Clear();
            ukuran2:
                Console.WriteLine(new string(' ', 13) + "UKURAN");
                Console.WriteLine(new string('=', 30));
                Console.WriteLine("1. Regular");
                Console.WriteLine("2. Tall");
                Console.WriteLine(new string('=', 30));
                Console.Write("Masukan menu [1/2]: ");
                ukuran = int.Parse(Console.ReadLine());
                if (ukuran == 1)
                {
                    namaUkuran = "Regular";
                    harga = 43000;
                    Console.Write("Masukan Jumlah: ");
                    jumlah = int.Parse(Console.ReadLine());

                }
                else if (ukuran == 2)
                {
                    namaUkuran = "Tall";
                    harga = 48000;
                    Console.Write("Masukan Jumlah: ");
                    jumlah = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ukuran tidak valid");
                    Console.ReadKey();
                    Console.Clear();
                    goto ukuran2;
                }
            }
            else if (menu == 3)
            {
                namaMenu = "Chocolate Frappuccino";
                Console.Clear();
                ukuran3:
                Console.WriteLine(new string(' ', 13) + "UKURAN");
                Console.WriteLine(new string('=', 30));
                Console.WriteLine("1. Regular");
                Console.WriteLine("2. Tall");
                Console.WriteLine(new string('=', 30));
                Console.Write("Masukan menu [1/2]: ");
                ukuran = int.Parse(Console.ReadLine());
                if (ukuran == 1)
                {
                    namaUkuran = "Regular";
                    harga = 45000;
                    Console.Write("Masukan Jumlah: ");
                    jumlah = int.Parse(Console.ReadLine());

                }
                else if (ukuran == 2)
                {
                    namaUkuran = "Tall";
                    harga = 50000;
                    Console.Write("Masukan Jumlah: ");
                    jumlah = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Ukuran tidak valid");
                    Console.ReadKey();
                    Console.Clear();
                    goto ukuran3;
                }
            }
            else
            {
                Console.WriteLine("Menu tidak valid");
                Console.ReadKey();
                Console.Clear();
                goto menu;
            }
            Console.Clear();
            total = harga * jumlah;
            Console.WriteLine($"Terima Kasih, Anda telah membeli {jumlah} {namaUkuran} {namaMenu} (@{harga.ToString("Rp #,##0.00")}) dengan  total {total.ToString("Rp #,##0.00")}.");
            
            Console.ReadKey();
        }
    }
}
