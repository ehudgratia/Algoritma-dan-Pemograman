using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class Diskusi
    {
        static int pilihan, jumlahProduk;
        static double subtotal = 0;
        static double total = 0;
        static char transaksi;

        enum Jenis
        {
            Lemari = 1, Meja = 2, Kursi = 3
        }

        struct Produk
        {
            public Jenis jenis;
            public string keterangan;
            public double harga;
            public double qty;
        }

        static Produk[] arr = new Produk[0];

        static void Input()
        {
            do
            {
            InputMenu:
                Console.Clear();

                Console.WriteLine(new string(' ', 23) + "MENU");
                Console.WriteLine(new string('*', 50));
                Console.WriteLine("1. Input");
                Console.WriteLine("2. Output");
                Console.WriteLine("3. Keluar");
                Console.WriteLine(new string('*', 50));
                Console.Write("Masukan pilihan menu [1-3] : ");
                pilihan = int.Parse(Console.ReadLine());
                if (pilihan == 1)
                {
                    Console.Clear();
                    Console.WriteLine(new string('*', 50));
                    Console.WriteLine(new string(' ', 20) + "Input Data");
                    Console.WriteLine(new string('*', 50));
                    Console.Write("Masukan jumlah barang : ");
                    jumlahProduk = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Array.Resize(ref arr, arr.Length + jumlahProduk);
                    for (int i = 0; i < jumlahProduk; i++)
                    {
                        Console.WriteLine("Jenis Produk : ");
                        Console.WriteLine("1. Lemari");
                        Console.WriteLine("2. Meja");
                        Console.WriteLine("3. Kursi");
                        Console.Write("Masukan jenis [1-3]\t: ");
                        arr[arr.GetUpperBound(0) - i].jenis = (Jenis)int.Parse(Console.ReadLine());

                        Console.WriteLine();

                        Console.Write("Masukan Keterangan\t: ");
                        arr[arr.GetUpperBound(0) - i].keterangan = Console.ReadLine();
                        Console.Write("Masukan Harga\t\t: ");
                        arr[arr.GetUpperBound(0) - i].harga = int.Parse(Console.ReadLine());
                        Console.Write("Masukan Qty\t\t: ");
                        arr[arr.GetUpperBound(0) - i].qty = int.Parse(Console.ReadLine());
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
            Console.WriteLine("Tanggal : {0}", DateTime.Today.ToString("dd-MM-yyyy"));

            Console.WriteLine(new String('-', 65));
            Console.WriteLine("Jenis".PadRight(10) + "Keterangan".PadRight(20) + "Harga".PadRight(15) + "Qty".PadRight(5) + "Subtotal");
            Console.WriteLine(new String('-', 65));

            for (int i = 0; i < arr.Length; i++)
            {
                subtotal = arr[i].harga * arr[i].qty;
                Console.WriteLine(arr[i].jenis.ToString().PadRight(10) + arr[i].keterangan.ToString().PadRight(20)+ arr[i].harga.ToString("Rp #,##0").PadRight(15)+arr[i].qty.ToString().PadRight(5) + subtotal.ToString("Rp #,##0"));
                total += subtotal;
            }
            Console.WriteLine(new string('-', 65));
            Console.WriteLine("Total : {0}".PadLeft(53), total.ToString("Rp #,##0"));
            total -= subtotal;
        }

        static void Main(string[] args)
        {
            Console.Title = "Furniture";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Input();
            Tampil();

            Console.ReadKey();
        }
    }        
}
