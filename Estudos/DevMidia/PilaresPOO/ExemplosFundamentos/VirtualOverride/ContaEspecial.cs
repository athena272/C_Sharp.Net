using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplosFundamentos.VirtualOverride
{
    public class ContaEspecial : ContaBancaria
    {
        public override double GetTarifaManutencao()
        {
            return 20;
        }
    }
}