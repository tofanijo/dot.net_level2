using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAUGIAU___MAZIAU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu Nr.1");
            double skaicius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu Nr.2");
            double skaicius2 = Convert.ToDouble(Console.ReadLine());
            skaicius1++;
            skaicius2--;
            Console.WriteLine("skaicius1 + 1: {0}, skaicius2 - 1: {1}", skaicius1, skaicius2  );
            Console.ReadKey();
        }
    }
}
