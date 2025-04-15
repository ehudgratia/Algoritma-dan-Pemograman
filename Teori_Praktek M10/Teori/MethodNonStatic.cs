using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class MethodNonStatic
    {
        string nama;
        static int Umur; 

        void Greating()
        {
            Console.WriteLine("Hello World");
        }
        void InputNamadanUmur()
        {
            Console.Write("Masukan Nama : ");
            nama = Console.ReadLine();
            Console.Write("Masukan Umur : ");
            Umur = int.Parse(Console.ReadLine());
        }
        void TampilNama()
        {
            Console.WriteLine($"Nama saya adalah {nama}");
        }
        static void TampilUmur()
        {
            Console.WriteLine($"Umur saya {Umur} tahun" );
        }
        void BGColorBlue()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
