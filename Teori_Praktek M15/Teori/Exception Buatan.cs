using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class Exception_Buatan
    {
        static void Main(string[] args)
        {
            Console.Title = "Exception Buatan";

            int saldo, nilai;
            saldo = 500000;
            try
            {
                Console.WriteLine("Saldo awal = {0}", saldo.ToString("Rp #,##0.00"));
                Console.Write("Masukan jumlah penarikan : ");
                nilai = int.Parse(Console.ReadLine());
                if (nilai <= 0)
                {
                    throw new Exception("Jumlah penarikan tidak boleh bernilai 0 atau minus.");
                }
                else if (nilai > saldo)
                {
                    throw new Exception("Jumlah penarikan tidak boleh lebih besar dari saldo.");
                }
                else
                {
                    saldo = saldo - nilai;
                }
                Console.WriteLine("Saldo akhir = {0}", saldo.ToString("Rp #,##0.00"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
