using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class Class2
    {
        static void Main()
        {
            Console.Title = "Sudut";
            double sin, cos, tan;

            Console.WriteLine("Sudut".PadLeft(5) + "Sin".PadLeft(10) + "Cos".PadLeft(10) ) ;
            Console.WriteLine(new String('=', 50));
            for (int i = 0; i <=360; i+=10)
            {
                sin = Math.Sin(i * Math.PI / 108);
                tan = Math.Tan(i * Math.PI / 108);
                cos = Math.Cos(i * Math.PI / 108);
                if (i==90 || i == 270)
                {
                    Console.WriteLine(i.ToString().PadLeft(5) + sin.ToString("0.00").PadLeft(10) + cos.ToString("0.00").PadLeft(10) + "~".PadLeft(10));
                }
                else
                {
                    Console.WriteLine(i.ToString().PadLeft(5) + sin.ToString("0.00").PadLeft(10) + cos.ToString("0.00").PadLeft(10) + cos.ToString("0.00").PadLeft(10));
                }
                
            }
            
            Console.WriteLine(new String('=', 50));
            Console.ReadKey();
        }
    }
}
