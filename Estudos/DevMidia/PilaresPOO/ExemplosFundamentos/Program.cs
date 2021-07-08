using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemplosFundamentos.StructExample;

namespace ExemplosFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            PontoGeometrico ponto = new PontoGeometrico();
            ponto.Latitude = "-40.0.0";
            ponto.Longitude = "-20.0.0";
            Console.WriteLine("Latitude:" + ponto.Latitude);
            Console.WriteLine("Longitude:" + ponto.Longitude);
            Console.ReadLine();
        }
    }
}