using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Praktek_M05
{
    class Task9
    {
        static void Main(string[] args)
        {
            Console.Title = "Computer Course";
            int hari;

            Console.Write("Masukan Hari [1-6] : ");
            hari = int.Parse(Console.ReadLine());

            switch (hari)
            {
                case 1:
                case 3:
                case 4:
                    Console.WriteLine("Instruktur yang bertanggung jawab adalah Larry Page");
                    break;
                case 2:
                case 5:
                case 6:
                    Console.WriteLine("Instruktur yang bertanggung jawab adalah Sergey Brin");
                    break;
                default:
                    Console.WriteLine("Instruktur yang bertanggung jawab adalah -");
                    break;
            }
            Console.ReadKey();
        }
    }
}
