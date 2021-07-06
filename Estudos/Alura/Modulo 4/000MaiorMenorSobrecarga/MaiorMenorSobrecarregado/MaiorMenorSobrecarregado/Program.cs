using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorMenorSobrecarregado
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparacao maiormenor = new Comparacao();
            Console.WriteLine(maiormenor.Maior(55, 99, 79));
            Console.ReadKey();
        }
    }
}
