using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace informacijos_issaugojimas_su_laiko_skaic
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datetoday;
            string kursopav;
            string mokyklospav;
            int studentskaic;
            DateTime pradzdat = new DateTime (2019, 12, 10);
            DateTime pabaigdat = new DateTime(2020, 02, 25);
            string darbodien;
            

            datetoday = DateTime.Now;
            kursopav = "NTV6";
            mokyklospav = "VGTU";
            studentskaic = 19;
            pradzdat = new DateTime(2019, 12, 10);
            pabaigdat = new DateTime(2020, 02, 25);
            darbodien = "20";

            Console.WriteLine("Siandienos data: {0}", datetoday);
            Console.WriteLine("Kurso pavadinimas: {0}", kursopav);
            Console.WriteLine("Mokyklos pavadinimas: {0}", mokyklospav);
            Console.WriteLine("Studentu skaicius: {0}", studentskaic);
            Console.WriteLine("Kurso pradzios data: {0}", pradzdat);
            Console.WriteLine("Kurso papaigos data: {0}", pabaigdat);
            Console.WriteLine("Darbo dienu skaicius: {0}", darbodien);

            Console.ReadLine();
        }
    }
}
