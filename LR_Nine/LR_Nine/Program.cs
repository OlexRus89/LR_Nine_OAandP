using System;
using System.Security.Cryptography.X509Certificates;

namespace LR_Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа № 11\n");

            ComputerTechnology.Notebook N = new ComputerTechnology.Notebook("br-150-12s", "HP");
            N.Price(25000);
            N.DrawObject();

            Console.WriteLine("\n");

            ComputerTechnology.Server S = new ComputerTechnology.Server("WDBKWB0160KBK-EEUE", "WD");
            S.Price(97000);
            S.DrawObject() ;

            Console.WriteLine("\n");

            ComputerTechnology.PersonalComputer P = new ComputerTechnology.PersonalComputer("Своя", "Olex", "ASRock", 15000, "Samsung", 7500, "MSI GeForge RTX 2060", 42990, "Intel Core I9", 56000, "Kingdom", 4200);
            P.Price(250000);
            P.DrawObject();

        }
    }
}
