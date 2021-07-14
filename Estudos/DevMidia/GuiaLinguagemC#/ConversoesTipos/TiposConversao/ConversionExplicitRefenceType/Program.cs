using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicitRefenceType
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
            Feminino Mulher = new Feminino();
            Humano serHumano = Mulher;
            Feminino outraMulher = serHumano as Feminino;

            //Dyaminc Example
            int par1 = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0 && par1 == 0)
                    par1 = i;
                else
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(SomarPares(par1, i));
                        par1 = 0;
                        /*
                         * 2 + 4
                         * 6 + 8
                         * 10 + 12
                         * 14 + 16
                         * 18 + 20
                         * 
                         */
                    }
            }


            
        }

        public static dynamic SomarPares(int par1, int par2)
        {
            return par1 + par2;
        }

    }
}
