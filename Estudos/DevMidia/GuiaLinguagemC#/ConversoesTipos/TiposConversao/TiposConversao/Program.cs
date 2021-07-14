using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposConversao
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 10;
            short b = a;
            int c = b;
            long d = c;
            float e = d;
            double f = e;

            Console.Write(f);
            Console.Read();
        }
    }
}
