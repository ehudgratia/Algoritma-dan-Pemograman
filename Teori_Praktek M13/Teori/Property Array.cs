using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Property_Array
    {
        static void Main(string[] args)
        {
            Console.Title = "Property Array";
            int[,] rect = new int[3,4] { { 2, 4, 6, 8 }, {5,10,15,20}, { 7, 14, 21, 28 } };
            Console.WriteLine("Banyak elemen pada dimensi-1\t: " + rect.GetLength(0));
            Console.WriteLine("Banyak elemen pada dimensi-2\t: " + rect.GetLength(1));
            Console.WriteLine("Indeks terendah pada dimensi-1\t: " + rect.GetLowerBound(0));
            Console.WriteLine("Indeks terendah pada dimensi-2\t: " + rect.GetLowerBound(1));
            Console.WriteLine("Indeks tertinggi pada dimensi-1\t: " + rect.GetUpperBound(0));
            Console.WriteLine("Indeks tertinggi pada dimensi-2\t: " + rect.GetUpperBound(1));
            Console.WriteLine("Banyak elemen keseluruhan\t: " + rect.Length);
            Console.WriteLine("Banyak dimensi\t\t\t: " + rect.Rank);
            Console.ReadKey();
        }
    }
}
