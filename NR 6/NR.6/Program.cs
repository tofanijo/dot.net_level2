using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR._6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tusciaEilute;
            Console.WriteLine("Iveskite betkokio teksto eilute");
            string tekstas = Console.ReadLine();

            if(tekstas.Length !=0)
            {
                tusciaEilute = true;
            }
            else
            {
                tusciaEilute = false;

            }
            Console.WriteLine(tusciaEilute);
            Console.ReadKey();
        }
    }
}
