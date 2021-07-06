using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A09
{
    class Program
    {
        static void Main(string[] args)
        {

            Random gerador = new Random();
            int n = gerador.Next(90);

            Console.WriteLine("Acabei de gerar o número: " + n);
            Console.ReadKey();
        }
    }
}
