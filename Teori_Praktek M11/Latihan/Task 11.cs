using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    class Task_11
    {

        static int celcius;

        public static double CelciusFahrenheit(int Celcius)
        {
            double fahrenheit = 9d / 5d * celcius;
            return fahrenheit;

        }

        public static double CelciusReamur(int Celcius)
        {
            double reamur = 4d / 5d * celcius;
            return reamur;

        }

        public static double CelciusKelvin(int Celcius)
        {
            double kelvin = celcius + 273;
            return kelvin;
        }

        static void InputSuhuCelcius()
        {
            Console.Write("Masukan suhu Celcius : ");
            celcius = int.Parse(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            int kode;

            Console.Title = "Konversi Suhu";
            MenuUtama:
            Console.WriteLine(new string (' ',18) + "Menu");
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("1. Celcius -> Reamur");
            Console.WriteLine("2. Celcius -> Fahrenheit");
            Console.WriteLine("3. Celcius -> Kelvin");
            Console.WriteLine(new string('=', 40));
        InputKode:
            Console.Write("Masukan Kode [1-3] : ");
            kode = int.Parse(Console.ReadLine());
            if ( kode == 1 )
            {
                InputSuhuCelcius();
                CelciusReamur(celcius);
                Console.WriteLine("Konversi dari suhu " + celcius + "celcius = " + CelciusReamur(celcius) + "suhu Reamur");
                
            }
            else if (kode == 2)
            {
                InputSuhuCelcius();
                CelciusFahrenheit(celcius);
                Console.WriteLine("Konversi dari suhu " + celcius + "celcius = " + CelciusFahrenheit(celcius) + "suhu Farenheit");

            }
            else if (kode == 3)
            {
                InputSuhuCelcius();
                CelciusKelvin(celcius);
                Console.WriteLine("Konversi dari suhu " + celcius + "celcius = " + CelciusKelvin(celcius) + "suhu Kelvin");
            }
            else
            {
                Console.WriteLine("Kode tidak valid");
                goto InputKode;
            }
            Console.ReadKey();
            goto MenuUtama;
        }
    }
}
