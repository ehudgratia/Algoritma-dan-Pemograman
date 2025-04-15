using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class MethodStatic
    {
        static String nama;
        static void InputNama()
        {
            Console.Write("Masukan Nama : ");
            nama = Console.ReadLine();
        }

        static void TampilNama()
        {
            Console.WriteLine("Nama saya adalah " + nama);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            InputNama();
            TampilNama();
            Console.ReadKey();
        }
    }
}
