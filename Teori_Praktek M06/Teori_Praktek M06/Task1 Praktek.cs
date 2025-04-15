using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Task1Praktek
    {
        static void Main(string[] args)
        {

            Console.Title = "Deret Bilangan Genap";
            int i, awal, akhir, total = 0;

            Console.Write(" Masukan awal: ");
            awal = int.Parse(Console.ReadLine());
            Console.Write("Masukan akhir : ");
            akhir = int.Parse(Console.ReadLine());

            if (awal % 2 == 0)
            {
                i = awal;
            }
            else
            {
                i = awal + 1;
            }
            while (i <= akhir)
            {
                Console.Write(i + "\t");
                total += i;
                i += 2;
            }
            Console.WriteLine();
            Console.WriteLine("Total =" + total);

            Console.ReadKey();
        }
    }
}
