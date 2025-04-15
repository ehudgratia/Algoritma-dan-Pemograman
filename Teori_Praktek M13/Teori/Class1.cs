using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.Title = "Penjumlahan dan Pengurangan Matriks";
            //deklarsi matriks
            int[,] matriks1 = new int[3, 3] { { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 } };
            int[,] matriks2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6, }, { 7, 8, 9 } };

            //penjumlahan matriks
            for (int i = 0; i < 3; i++) //baris
            {
                for (int j = 0; j <= matriks1.GetUpperBound(1); j++)
                {
                    Console.Write(matriks1[i, j] + "\t");
                }

                //simbol + dicetak ketika masuk baris ke-2
                if (i == 1) //jika index 1 / baris 2
                {
                    Console.Write("+\t"); // cetak tanda + dan tab
                }
                else
                {
                    Console.Write("\t");
                }

                for (int j = 0; j <= matriks2.GetUpperBound(1); j++)
                {
                    Console.Write(matriks2[i, j] + "\t");
                }

                //simbol = dicetak ketika masuk baris ke 2
                if (i == 1)
                {
                    Console.Write("=\t");
                }
                else
                {
                    Console.Write("\t");
                }

                //perulangan untuk menjumlah kedua matriks
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriks1[i, j] + matriks2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //pengurangan matriks
            for (int i = 0; i <= matriks1.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matriks1.GetUpperBound(1); j++)
                {
                    Console.Write(matriks1[i, j] + "\t");
                }

                //simbol- dicetak ketika masuk baris ke-2 
                if (i == 1)
                {
                    Console.Write("-\t");
                }
                else
                {
                    Console.Write("\t");
                }

                for (int j = 0; j <= matriks2.GetUpperBound(1); j++)
                {
                    Console.Write(matriks2[i, j] + "\t");
                }

                //simbol = dicetak ketika masuk baris ke-2''
                if (i == 1)
                {
                    Console.Write("=\t");
                }
                else
                {
                    Console.Write("\t");
                }

                //perulangan untuk kedua matriks
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriks1[i, j] - matriks2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
