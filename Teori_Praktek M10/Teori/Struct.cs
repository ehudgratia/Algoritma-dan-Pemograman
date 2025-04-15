using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Struct
    {
        struct Barang
        {
            public string kodebarang, namabarang;
            public int harga, barang;
        }
        static void Main()
        {
            Barang brg;
            Console.Write("Masukan Kode Barang : ");
            brg.kodebarang = Console.ReadLine();
            Console.Write("Masukan Nama Barang : ");
            brg.namabarang = Console.ReadLine();
            Console.Write("Masukan Harga Barang : ");
            brg.harga = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Kode Barang : " + brg.kodebarang);
            Console.WriteLine("Nama Barang : " + brg.namabarang);
            Console.WriteLine("Harga Barang : " + brg.harga);
            Console.ReadKey();
        }
    }
}
