using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_skaiciai_skirtumas_suma_dalyba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sveiki!");

            double skaicius1;
            double skaicius2;

            Console.WriteLine("Iveskite skaicius1");
            skaicius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaicius2");
            skaicius2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Skaiciu suma: " + (skaicius1 + skaicius2));
            Console.WriteLine("Skaiciu skirtumas: " + (skaicius1 - skaicius2));
            Console.WriteLine("Skaiciu sandauga: " + (skaicius1 * skaicius2));
            Console.WriteLine("Skaiciu skirtumas: " + (skaicius1 / skaicius2));



            Console.ReadLine();
        }
    }
}
