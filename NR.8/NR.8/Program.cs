using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string Vardas = "";
            string Pavarde = "";
            Console.WriteLine("Iveskite savo Varda:");
            Vardas= Console.ReadLine();
            Console.WriteLine("Iveskite savo Pavarde:");
            Pavarde = Console.ReadLine();

            Console.Write("Jusu Vardas Pavarde: {0} {1}", Vardas, Pavarde);
            Console.ReadLine();
        }
    }
}
