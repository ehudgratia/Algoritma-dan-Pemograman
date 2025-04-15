using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Enum
    {
        enum Hari 
        {
            Senin, Selasa, Rabu, Kamis,Jumat, Sabtu, Minggu
        }
        static void Main()
        {
            Console.Write("Masukan hari keberapa [0-6] : ");
            Hari hari = (Hari)int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine($"Hari yang anda pilih adalah {hari}");
            Console.ReadKey();
        }
    }
}
