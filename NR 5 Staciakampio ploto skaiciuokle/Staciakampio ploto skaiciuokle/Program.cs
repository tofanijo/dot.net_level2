using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staciakampio_ploto_skaiciuokle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Staciakampio ploto skaiciuokle");
            Console.WriteLine("[Pradeti - Enter] [Iseiti -e]");
            while (Console.ReadLine() != "e")

            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Iveskite staciakampio ilgi m");
                    double sk1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Iveskite staciakampio ploti m");
                    double sk2 = Convert.ToDouble(Console.ReadLine());


                    double vidurkis = (sk1 * sk2);

                    Console.WriteLine();
                    Console.WriteLine("Staciakampio plotas: {0}", vidurkis);
                    Console.WriteLine();
                    //Console.WriteLine("[Pakartoti - Enter] [iseiti - e]");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Skaiciu vidurkio saiciavimas");
                    Console.WriteLine("[Pradeti - Enter] [Iseiti - e]");
                }
            }
        }
    }
}

