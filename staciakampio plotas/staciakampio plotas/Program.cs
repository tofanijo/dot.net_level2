using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staciakampio_plotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            double Plotas;
            string veiksmas = "";
            while (veiksmas != "exit")
            {
                Console.WriteLine("Iveskite staciakampio ilgi:");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("iveskite veiksma [+, -, /, *], arba exit");
                veiksmas = Console.ReadLine();
                Console.WriteLine("Iveskite staciakampio ploti:");
                B = Convert.ToInt32(Console.ReadLine());


                switch (veiksmas)
                {
                    case "*":
                        Plotas = A * B;
                        RodytiRezultata(Plotas);
                        break;
                    case "exit":
                        Console.WriteLine("Viso gero!");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Neteisingai ivestas veiksmas, pakartokite");
                        break;
                }
            }
            void RodytiRezultata(double aRezultatas)
            {
                {
                    Console.WriteLine("Plotas yra : {0}", aRezultatas);




                }

            }
        }
    }
}
