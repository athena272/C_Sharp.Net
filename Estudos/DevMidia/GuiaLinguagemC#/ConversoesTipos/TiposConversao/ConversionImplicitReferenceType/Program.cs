using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionImplicitReferenceType
{
    class Humano
    {
        //Propriedades e Métodos
    }
    class Feminino : Humano
    {
        //Propriedades e Métodos
    }
    class Masculino : Humano
    {
        //Propriedades e Métodos
    }

    class Program
    {
        static void Main(string[] args)
        {
            Masculino Robson = new Masculino();
            Humano humano = Robson;
            Console.WriteLine(humano);
            Console.ReadKey();
        }
    }
}
