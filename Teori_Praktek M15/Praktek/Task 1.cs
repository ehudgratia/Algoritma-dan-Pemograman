using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class Task_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Kendaraan";

            double km, l, hasil;

            try
            {
                Console.Write("Masukkan kilometer yang ditempuh : ");
                km = double.Parse(Console.ReadLine());
                Console.Write("Masukkan liter bahan bakar       : ");
                l = double.Parse(Console.ReadLine());

                if (km < 0 || l < 0)
                {
                    throw new Exception("Data yang diinput tidak boleh bernilai minus!");
                }
                hasil = km / l;
                Console.WriteLine("Km/L kendaraan anda              : {0}", hasil.ToString("0.00"));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Data yang diinput harus berupa angka!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
