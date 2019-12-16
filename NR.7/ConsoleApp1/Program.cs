using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite skaiciu Nr.1");
            double skaicius1 = Convert.ToDouble(Console.ReadLine());

            Palyginimas(skaicius1);

            Console.WriteLine("Skaicius > uz 0:" + Palyginimas(skaicius1));
            Console.ReadLine();

            bool Palyginimas(double aSkaicius1)
            {
                if (aSkaicius1 < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }



            }
        }
    }
}



