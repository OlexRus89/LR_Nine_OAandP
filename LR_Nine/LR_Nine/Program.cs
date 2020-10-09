using LR_Nine;
using System;
using System.Security.Cryptography.X509Certificates;

namespace LR_Nine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа № 11\n");

            Notebook N = new Notebook("br-150-12s", "HP");
            N.Price(25000);
            N.DrawObject();

            Console.WriteLine("\n");

            Server S = new Server("WDBKWB0160KBK-EEUE", "WD");
            S.Price(97000);
            S.DrawObject() ;

            Console.WriteLine("\n");

            PersonalComputer P = new PersonalComputer("Своя", "Olex", "ASRock", 15000, "Samsung", 7500, "MSI GeForge RTX 2060", 42990, "Intel Core I9", 56000, "Kingdom", 4200);
            P.Price(250000);
            P.DrawObject();

        }
    }
}
