 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Class1
    {
        public static void Greeting(string pesan, string nama, int umur)
        {
            Console.WriteLine($"Hai {pesan} , Nama saya {nama} umur saya {umur} Tahun");
        }

        static void Main(string[] args)
        {
            Greeting("Selamat Pagi", "Yumaida", 24);
            Console.ReadKey();
        }
    }
}
