﻿using System;


namespace Opdracht_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            int geboortedatum;

            Console.WriteLine("Wat is je voornaam?");
            string naam = Console.ReadLine();
            Console.WriteLine("Vul hier je geboortedatum in");
            Console.WriteLine("dag:");
            int dag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("maand:");
            int maand = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("jaar:");
            int jaar = Convert.ToInt32(Console.ReadLine());

            var vandaag = DateTime.Today;
            var vandaagberekening = (DateTime.Today.Year * 100 + DateTime.Today.Month) * 100 + DateTime.Today.Day;
            var geboortedatumberekening = (jaar * 100 + maand) * 100 + dag;
            var leeftijd = (vandaagberekening - geboortedatumberekening) / 10000;
            Console.Clear();
            Console.WriteLine(naam);
            Console.WriteLine(leeftijd);
            Console.Read();
        }
    }
}
