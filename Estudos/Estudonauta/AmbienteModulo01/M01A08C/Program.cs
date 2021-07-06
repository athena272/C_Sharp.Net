using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = 0;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("O valor digitao foi " + n);
            Console.ReadKey();
            
        }
    }
}
