using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class Class1
    {
        enum Bulan
        {
            Januari=1,Febuari, MAret, April, Mei, Juni, Juli, Agustus, September, Oktober, November, Desember
        }
        static void Main()
        {
            Console.Title = "Enum Bulan";
            Console.Write("Masukan Kode bulan [1-12] : ");
            Bulan bulan = (Bulan)int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(bulan);
            Console.ReadKey();
        }
    }
}
