using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string miestas;
            string gatve;
            double namoNr;
            double namoStatybosMetai;

            miestas = "Vilnius";
            gatve = "Sviesos g";
            namoNr = 11;
            namoStatybosMetai = 1987;

            Console.WriteLine("Miesto pavadinimas: {0}", miestas);
            Console.WriteLine("Gatves pavadinimas: {0}", gatve);
            Console.WriteLine("Namo numeris: {0}", namoNr);
            Console.WriteLine("Namo numeris: {0}", namoStatybosMetai);
            Console.ReadLine();
        }
    }
}
