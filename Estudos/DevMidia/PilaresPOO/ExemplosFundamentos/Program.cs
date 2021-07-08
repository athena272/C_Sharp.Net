using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemplosFundamentos.VirtualOverride;

namespace ExemplosFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancariaA = new ContaBancaria();
            Console.WriteLine("contaBancariaA: " + contaBancariaA.GetTarifaManutencao());
            Console.WriteLine("...............");
            ContaBancaria contaBancariaB = new ContaUniversitaria();
            Console.WriteLine("contaBancariaB: " + contaBancariaB.GetTarifaManutencao());
            Console.WriteLine("...............");
            ContaBancaria contaBancariaC = new ContaEspecial();
            Console.WriteLine("contaBancariaC: " + contaBancariaC.GetTarifaManutencao());
            Console.WriteLine("...............");
            Console.ReadLine();
        }
    }
}