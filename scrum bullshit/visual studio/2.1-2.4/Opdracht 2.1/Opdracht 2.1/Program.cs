using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Jarno Nijland");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Beltrumeseweg 44");
            Console.WriteLine("7151EW Eibergen");
            Console.WriteLine("17 jaar");
            Console.ReadKey();
        }
    }
}