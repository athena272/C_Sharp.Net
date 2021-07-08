using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplosFundamentos.VirtualOverride
{
    public class ContaUniversitaria : ContaBancaria
    {
        public override double GetTarifaManutencao()
        {
            return 10;
        }
    }
}