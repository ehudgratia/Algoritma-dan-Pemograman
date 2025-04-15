using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Program
    {
        public static void ByValueCth(int nilai1)
        {
            nilai1 += 5;
        }
        public static void ByRefCth(ref int nilai1)
        {
            nilai1 += 5;
        }
        static void Main(string[] args)
        {
            Console.Write("Input Nilai [ValueType] : ");
            int inputV = int.Parse(Console.ReadLine());
            Console.Write("Input Nilai [RefType] : ");
            int inputR = int.Parse(Console.ReadLine());

            ByValueCth(inputV);
            ByRefCth(ref inputR);
            Console.WriteLine("Hasil dari Pass by Value = " + inputV);
            Console.WriteLine("Hasil dari Pass by Ref = " + inputR);
            Console.ReadKey();
        }
    }
}
