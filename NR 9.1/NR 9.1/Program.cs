using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NR_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string miestas;
            //string gatve;
            //string namoNr;
            //string DateTime;

            //miestas = "";
            //gatve = "";
            //namoNr = "";
            //DateTime = "";


            
            Console.WriteLine("Miesto pavadinimas:");
            string miestas =  Console.ReadLine();
            
            Console.WriteLine("Gatves pavadinimas:");
            string gatve = Console.ReadLine();
           
            Console.WriteLine("Namo numeris:");
            string namoNr = Console.ReadLine();
            
            Console.WriteLine("Namo statybos metai:");
            DateTime statybosMetai = DateTime.Parse(Console.ReadLine());

            RodytiInfo(miestas, gatve, namoNr);

            Console.ReadLine();



            void RodytiInfo(string amiestas, string agatve, string anamorNr)
            {
                Console.WriteLine("Miestas: {0}", amiestas, agatve, anamorNr);
                Console.WriteLine("Gatve: {1}", miestas, agatve, anamorNr);
                Console.WriteLine("Namo nr: {2}", miestas, agatve, anamorNr);
                Console.WriteLine("Statybos metai: {0}", statybosMetai);
                Console.ReadLine();
                

                


               



            }
        }
    }
}
