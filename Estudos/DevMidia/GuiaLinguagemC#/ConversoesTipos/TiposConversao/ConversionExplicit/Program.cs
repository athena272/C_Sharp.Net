using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 10;
            short b = (short)a;
            int c = (int)b;
            long d = (long)c;
            float e = (long)d;
            double f = (float)e;
            Console.Write(f);
            Console.Read();
        }
    }
}
