using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saugoma_informacija1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datetoday;
            string kursopav;
            string mokyklospav;
            int studentskaic;

            datetoday = DateTime.Now;
            kursopav = "NTV6";
            mokyklospav = "VGTU";
            studentskaic = 19 ;

            Console.WriteLine("Siandienos data: {0}", datetoday);
            Console.WriteLine("Kurso pavadinimas: {0}", kursopav);
            Console.WriteLine("Mokyklos pavadinimas: {0}", mokyklospav);
            Console.WriteLine("Studentu skaicius: {0}", studentskaic);

            Console.ReadLine();




        }
    }
}
