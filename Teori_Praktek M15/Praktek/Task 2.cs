

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class Task_2   
    {
        static void Main(string[] args)
        {
            Console.Title = "Besaran Waktu";

            int jam, menit, detik;

            try
            {
                Console.Write("Masukkan besaran jam   : ");
                jam = int.Parse(Console.ReadLine());
                if (jam < 0 || jam > 23) //selain dari 0 atau 23
                {
                    throw new Exception("Besaran jam harus di antara 0 sampai 23!");
                }

                Console.Write("Masukkan besaran menit : ");
                menit = int.Parse(Console.ReadLine());
                if (menit < 0 || menit > 59) //selain dari 0 atau 59
                {
                    throw new Exception("Besaran menit harus di antara 0 sampai 59!");
                }

                Console.Write("Masukkan besaran detik : ");
                detik = int.Parse(Console.ReadLine());
                if (detik < 0 || detik > 59) //selain dari 0 atau 59
                {
                    throw new Exception("Besaran detik harus di antara 0 sampai 59!");
                }

                Console.WriteLine("Besaran waktu          : " + jam.ToString("00") + ":" + menit.ToString("00") + ":" + detik.ToString("00"));
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Besaran waktu yang diinput harus berupa angka");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
