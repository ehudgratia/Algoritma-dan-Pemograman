using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.Title = "Array";
            String[] nama = new string[5] { "ucok", "Butet", "Iyem", "Jono", "Robi" };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nama ke- {0} = {1}", i + 1, nama[1]);
            }
            Console.ReadKey();
        }
    }
}
