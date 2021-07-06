using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int dobro = n * 2;
            Console.WriteLine("O valor digitado foi " + n + " e o seu dobro é " + dobro);
            Console.ReadKey();
        }
    }
}
