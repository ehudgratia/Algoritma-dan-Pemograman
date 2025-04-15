using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktek
{
    class ClassandObject
    {
        static void Main()
        {
            film film = new film();
            film film2 = new film();

            film.judul = "The Iron Man";
            film.sutradara = "Jon Faveraw";
            film.rating = 9;
            film2.judul = "The Avanger";
            film2.sutradara = "Antony Russo";
            film2.rating = 10;

            Console.WriteLine($"Film 1 dengan judul : {film.judul}, disutradarai oleh {film.sutradara}, dengan rating sebanyak {film.rating}");
            Console.WriteLine($"Film 2 dengan judul : {film2.judul}, disutradarai oleh {film2.sutradara}, dengan rating sebanyak {film2.rating}");
            Console.ReadKey();
        }
    }

    class film
    {
        public string judul, sutradara;
        public int rating;
    }
}
