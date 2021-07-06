using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu nome?: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Muito prazer em te conhecer, " + nome);
            Console.ReadKey();
        }
    }
}
