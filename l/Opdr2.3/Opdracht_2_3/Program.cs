using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Getal1 = 0;
;           int Getal2 = 0;
            int Resultaat = 0;
            
            Console.Write("Voer getal 1 in:");
            Getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Voer getal 2 in:");
            Getal2 = Convert.ToInt32(Console.ReadLine());

            Resultaat = Getal1 + Getal2;
            Console.WriteLine("{0} + {1} = {2}", Getal1, Getal2, Resultaat);
            Resultaat = Getal1 - Getal2;
            Console.WriteLine("{0} - {1} = {2}", Getal1, Getal2, Resultaat);
            Resultaat = Getal2 - Getal1;
            Console.WriteLine("{0} - {1} = {2}", Getal2, Getal1, Resultaat);
            Resultaat = Getal1 * Getal2;
            Console.WriteLine("{0} X {1} = {2}", Getal1, Getal2, Resultaat);
            Resultaat = Getal1 / Getal2;
            Console.WriteLine("{0} : {1} = {2}", Getal1, Getal2, Resultaat);
            Resultaat = Getal2 / Getal1;
            Console.WriteLine("{0} : {1} = {2}", Getal2, Getal1, Resultaat);
            Resultaat = Getal1 % Getal2;
            Console.WriteLine("{0} % {1} = {2}", Getal1, Getal2, Resultaat);
            Resultaat = Getal2 % Getal1;
            Console.WriteLine("{0} % {1} = {2}", Getal2, Getal1, Resultaat);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
