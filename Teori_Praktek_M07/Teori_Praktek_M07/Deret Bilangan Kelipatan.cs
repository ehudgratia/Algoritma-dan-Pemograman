using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Teroi_Praktek_M07
{
    class Deret_Bilangan_Kelipatan
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Deret Bilangan";

            int kelipatan, n, nilai = 1;

            Console.Write("Masukan kelipatan : ");
            kelipatan = int.Parse(Console.ReadLine());
            Console.Write("Masukan n : ");
            n = int.Parse(Console.ReadLine());

            while (nilai <= n )
            {
                Console.Write(kelipatan*nilai + "\t");
                nilai++;
            }

            Console.ReadKey();
        }
    }
}
