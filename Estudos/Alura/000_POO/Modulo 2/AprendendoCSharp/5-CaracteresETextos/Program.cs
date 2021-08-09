using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            //Character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);
            //Casting
            primeiraLetra = (char) 65;
            Console.WriteLine(primeiraLetra);
            //Casting compost
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Curso de Tecnologia " + 2021;
            //Para criar com varias linhas, colocar @
            string cursosProgramacao = @" 
             - .NET 
             - Java 
             - JavaScript";
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);

            Console.ReadKey();
        }
    }
}
