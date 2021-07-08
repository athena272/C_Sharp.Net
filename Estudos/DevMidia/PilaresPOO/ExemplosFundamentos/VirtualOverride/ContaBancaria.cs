using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplosFundamentos.VirtualOverride
{
    public class ContaBancaria
    {
        public int Agencia { get; set; }

        public int Conta { get; set; }

        public int Digito { get; set; }

        public virtual double GetTarifaManutencao()
        {
            return 30;
        }
    }
}