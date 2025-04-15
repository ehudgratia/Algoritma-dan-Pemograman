using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS
{
    class Program
    {
        static int pilihan, jumlahProduk;
        static double subtotal = 0;
        static double total = 0;
        static char transaksi;



        enum Jenis
        {
            Botol = 1, Rantang = 2, Toples = 3, Wadah = 4
        }

        enum Merek
        {
            Tupperware = 1, Ecentio = 2, Yooyee = 3, Zojirushi = 4, Freemir = 5
        }

        struct Produk
        {
            public Jenis jenis;
            public Merek merek;
            public string warna;
            public double harga;
            public double diskon;
            
            
        }

        static Produk[] arr = new Produk[0];

        static void Input()
        {
            do
            {
            InputMenu:
                Console.Clear();

                Console.WriteLine(new string(' ', 23) + "MENU");
                Console.WriteLine(new string('=', 50));
                Console.WriteLine("1. Input Data");
                Console.WriteLine("2. Output Data");
                Console.WriteLine("3. Keluar");
                Console.WriteLine(new string('*', 50));
                Console.Write("Masukan pilihan menu [1-3] : ");
                pilihan = int.Parse(Console.ReadLine());
                if (pilihan == 1)
                {
                    Console.Clear();
                    Console.WriteLine(new string('*', 50));
                    Console.WriteLine(new string(' ', 20) + "INPUT DATA");
                    Console.WriteLine(new string('*', 50));
                    Console.Write("Masukan jumlah produk : ");
                    jumlahProduk = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Array.Resize(ref arr, arr.Length + jumlahProduk);
                    for (int i = 0; i < jumlahProduk; i++)
                    {
                        Console.WriteLine("Jenis Produk : ");
                        Console.WriteLine("1. Botol");
                        Console.WriteLine("2. Rantang");
                        Console.WriteLine("3. Toples");
                        Console.WriteLine("4. Wadah");
                        Console.Write("Masukan jenis [1-4]\t: ");
                        arr[arr.GetUpperBound(0) - i].jenis = (Jenis)int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        Console.WriteLine("Merek :");
                        Console.WriteLine("1. Tupperware");
                        Console.WriteLine("2. Ecentio");
                        Console.WriteLine("3. Yooyee");
                        Console.WriteLine("4. Zojirushi");
                        Console.WriteLine("5. Freemir");
                        Console.Write("Masukan merek [1-5]\t: ");
                        arr[arr.GetUpperBound(0) - i].merek = (Merek)int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Masukan Warna\t\t: ");
                        arr[arr.GetUpperBound(0) - i].warna = Console.ReadLine();
                        Console.Write("Masukan Harga\t\t: ");
                        arr[arr.GetUpperBound(0) - i].harga = int.Parse(Console.ReadLine());

                        arr[1].diskon = arr[i].harga * 10 / 100;

                        Console.WriteLine();
                    }
                    goto InputMenu;

                }
                else if (pilihan == 2)
                {
                    Tampil();
                    Console.Write("apakah Anda ingin melakukan transaksi lagi? [Y/T] : ");
                    transaksi = char.Parse(Console.ReadLine());
                }
                else if (pilihan == 3)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid");
                    Console.ReadKey();
                    goto InputMenu;
                }
            } while (transaksi == 'y' || transaksi == 'Y');

        }

        static void Tampil()
        {
            Console.Clear();
            Console.WriteLine("Tanggal : {0}", DateTime.Today.ToString("dd-MMMM-yyyy"));

            Console.WriteLine(new String('=', 75));
            Console.WriteLine("Jenis".PadRight(10) + "Merek".PadRight(15) + "Warna".PadRight(15) + "Harga".PadRight(15) + "Diskon".PadRight(10) + "Subtotal");
            Console.WriteLine(new String('=', 75));

            for (int i = 0; i < arr.Length; i++)
            {
                arr[0].diskon = arr[i].harga * 10 / 100;
                subtotal = arr[i].harga - arr[i].diskon;
                Console.WriteLine(arr[i].jenis.ToString().PadRight(10) + arr[i].merek.ToString().PadRight(15) + arr[i].warna.ToString().PadRight(15) + arr[i].harga.ToString("Rp #,##0").PadRight(15) + arr[i].diskon.ToString("Rp #,##0").PadRight(10) + subtotal.ToString("Rp #,##0"));
                total += subtotal;
            }
            Console.WriteLine(new string('=', 75));
            Console.WriteLine("Total : {0}".PadLeft(68), total.ToString("Rp #,##0"));
            total -= subtotal;
        }

        static void Main(string[] args)
        {
            Console.Title = "Perlengkapan Makan Siang";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Input();
            Tampil();

            Console.ReadKey();
        }



    }
}
