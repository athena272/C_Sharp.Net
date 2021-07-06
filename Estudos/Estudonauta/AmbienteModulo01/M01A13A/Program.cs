using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A13A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * :C ==> Monetário (currency) 
             * 
             * :D ==> Decimal (inteiro)
             *
             * :N ==> Número (real)
             * 
             * :E ==> Científico
             *
             * :X ==> Hexadecimal
             *   
            */
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            string nome = "Gustavo";
            float salario = 550.7566f;
            //20 alinhado a direita, -20 alinha a esquerda
            Console.WriteLine($"Muito prazer em te conhecer {nome, 15}!!!");
            Console.ReadKey();
            //Change color
            Console.ForegroundColor = ConsoleColor.Black; 
            Console.BackgroundColor = ConsoleColor.White;
            
        }
    }
}
