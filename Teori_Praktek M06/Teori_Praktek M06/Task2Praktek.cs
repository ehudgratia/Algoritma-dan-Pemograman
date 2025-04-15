using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori_Praktek_M06
{
    class Task2Praktek
    {
        static void Main(string[] args)
        {
            Console.Title = "Faktorial";

            int faktorial, total = 1;

            Console.Write("Masukan Faktorial : ");
            faktorial = int.Parse(Console.ReadLine());
            Console.Write(faktorial + "! = ");
            while (faktorial >= 1)
            {
                total *= faktorial;
                if (faktorial != 1)
                {
                    Console.Write(faktorial + " x ");
                }
                else if (faktorial == 1)
                {
                    Console.Write(faktorial + " = ");
                }
                faktorial -= 1;
            }

            Console.Write(total);
            Console.ReadKey();
        }
    }
}
