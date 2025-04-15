using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Latihan_1
    {
        public static void Hello (string nama)
        {
            Console.WriteLine("Hello " + nama);
            Console.WriteLine("Senang bertemu dengan Anda");
        }
        static void Main(string[] args)
        {
            Console.Title = "Welcome";
            String nama;
            Console.Write("Masukan nama Anda : ");
            nama = Console.ReadLine();


            Hello(nama);
            Console.ReadKey();

        }
    }
}
