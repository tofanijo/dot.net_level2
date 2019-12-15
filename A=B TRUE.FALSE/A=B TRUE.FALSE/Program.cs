using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_B_TRUE.FALSE
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Iveskite skaiciu Nr.1");
            double skaicius1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu Nr.2");
            double skaicius2 = Convert.ToDouble(Console.ReadLine());
            


            if(skaicius1 == skaicius2)

            {
                Console.WriteLine("TRUE!");
                Console.WriteLine("[ISEITI - e]");
                //while (Console.ReadLine() != "e") ;
            }
            else
            {
                Console.WriteLine("FALSE!");
                Console.WriteLine("[ISEITI - e]");
                //while (Console.ReadLine() != "e") ;
            }

            Console.ReadKey();


                   

        }
    }
}
