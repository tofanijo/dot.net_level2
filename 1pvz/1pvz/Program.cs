using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearOfBirth;
            string firstName;
            string tevovardas;


            var lastName = "Pavardenis";
            decimal salary = 1999.9m;
            DateTime lastPayDay = DateTime.Today.AddMonths(-1);

            yearOfBirth = 1990;
            firstName = "Vardenis";
            tevovardas = "Rimantas";

            Console.WriteLine("Vardas, Pavarde: {0}, {1}, {2},", firstName, lastName, tevovardas);

            Console.WriteLine("Gimimo metai: {0}", yearOfBirth);
            Console.WriteLine("Pajamos: {0}", salary);
            Console.WriteLine("Paskutini karta ismoketa alga: {0}", lastPayDay.ToLongDateString());
            Console.ReadLine();








        }
    }
}
