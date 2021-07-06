using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A12B
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            Console.Write("Qual seu salário?: R$");
            float.TryParse(Console.ReadLine(), out salario);
            //:C server para montar o valor em dinheiro
            Console.WriteLine($"Você ganha {salario:C} por més");
            Console.ReadKey();
        }
    }
}
