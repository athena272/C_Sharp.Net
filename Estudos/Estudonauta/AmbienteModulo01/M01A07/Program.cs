using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversao Implicita int ==> float
            /* 
             int a = 8;
             float b = 8;
            */
            //Conversao Explicita float ==> int
            /*
             float a = 8.9999f;
             int b = (int) a;
            */
            //Conversao por Classes auxiliares
            float a = 8.502f;
            int b = Convert.ToInt16(a);

            Console.WriteLine("O valor de a é " + a + " e o seu tipo é " + a.GetType());
            Console.WriteLine("O valor de b é " + b + " e o seu tipo é " + b.GetType());
            Console.ReadLine();
        }
    }
}
