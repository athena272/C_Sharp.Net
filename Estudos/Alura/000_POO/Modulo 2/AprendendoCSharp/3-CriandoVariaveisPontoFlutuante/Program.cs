using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Variaveis Ponto Flutuante");
            //Declare variable
            double salario = 1250.70;
            Console.WriteLine("Meu salário é R$" + salario);

            //Divison between variables
            double division = 5 / 2.0;
            Console.WriteLine(division);

            Console.WriteLine("Execução Finalizada. Tecle enter para sair. . .");
            Console.ReadKey();
        }
    }
}
