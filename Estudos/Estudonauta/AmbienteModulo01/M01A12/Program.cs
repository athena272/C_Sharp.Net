using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu nome?: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}!, prazer em te conhecer");

            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.WriteLine($"Hoje é dia {dia} do mês {mes} do ano de {ano}");

            Console.ReadKey();



        }
    }
}
