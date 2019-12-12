using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savarankiskas2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1;
            int B = 15;
            int C;

            C = A;
            A = B;
            B = C;

            Console.WriteLine("A: {0}", A);
            Console.WriteLine("B: {0}", B);
            Console.ReadLine();

        }
    }
}
