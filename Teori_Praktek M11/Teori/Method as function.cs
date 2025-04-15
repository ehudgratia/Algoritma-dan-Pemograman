using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Method_as_function
    {
        public static int Greeting(int tahunlahir, int tahunsekarang)
        {
            int umur = tahunsekarang - tahunlahir;
            return umur;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Umur saya sekarang adalah " + Greeting(2002, 2022) + "tahun");
            Console.ReadKey();
        }
    }
}
