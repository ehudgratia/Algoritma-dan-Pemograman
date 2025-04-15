using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teori
{
    class try_catch
    {
        static void Main(string[] args)
        {
            Console.Title = "Try...Catch";
            int nilai;
            try
            {
                Console.Write("Masukan nilai : ");
                nilai = int.Parse(Console.ReadLine());
                Console.WriteLine("Nilai yang dimasukan adalah " + nilai); //Console.WriteLine("Nilai yang Anda masukan adalah {0}", nilai);
            }
            catch (Exception ex)
            {
                //pesan eror default
                //Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
