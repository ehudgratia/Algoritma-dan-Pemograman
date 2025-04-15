using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class SwitchMultipleSelectionStatement
    {
        static void Main(string[] args)
        {
            int menu;
            Console.Write("Masukan menu makanan [1/2/3] : ");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Nasi Goreng");
                    break;
                case 2:
                    Console.WriteLine("Mie Ayam");
                    break;
                case 3:
                    Console.WriteLine("Sate Padang");
                    break;
                default:
                    Console.WriteLine("Nasi Kecap");
                    break;
            }
            Console.ReadKey();
        }
    }
}
