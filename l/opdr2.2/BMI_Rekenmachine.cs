using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je Gewicht: ");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef je Lengte: ");
            double lengte = Convert.ToDouble(Console.ReadLine());

            Double BMI = gewicht / (lengte * lengte);
            Console.WriteLine(" BMI is " + BMI);

            Console.ReadKey();
        }
    }
}
