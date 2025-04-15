using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class Task8
    {
        static void Main(string[] args)
        {
            Console.Title = "Anggota Perpustakaan";
            Char jawab;

            Console.Write("Apakah Anda merupakan seorang member ? [Y/T]"); 
            Console.Write("Jawab : ");
            jawab = char.Parse(Console.ReadLine());
            

            Console.WriteLine(jawab.ToString().ToUpper() == "Y" ? "Member : Anda dapat meminjam lebih dari dua buku" : "Bukan Member : Anda hanya dapat meminjam maksimal 2 buku");

            Console.ReadKey();
        }
    }
}
