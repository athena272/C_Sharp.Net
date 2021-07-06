using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorMenorSobrecarregado
{
    public class Comparacao
    {
        public double Maior(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        public double Maior(double a, double b, double c)
        {
            double maiorEntreAeB = Maior(a, b);
            return Maior(maiorEntreAeB, c);
        }
    }
}
