using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversorEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1270.50;
            int valorInteiro = (int) salario;
            Console.WriteLine(valorInteiro);

            double idade = 30.0;
            Console.WriteLine("A idade de Marcos é " + (int) idade +"!");

            Console.WriteLine("Execução Finalizada. Tecle enter para sair. . .");
            Console.ReadKey();
        }
    }
}
