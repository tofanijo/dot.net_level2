using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace savarankiskas1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ratas = "";
            Console.WriteLine("Iveskite skaiciu:");
            ratas = Console.ReadLine();

            Console.Write("{0} {0} {0}, {0}",  ratas);
            Console.ReadLine();
        }
    }
}
