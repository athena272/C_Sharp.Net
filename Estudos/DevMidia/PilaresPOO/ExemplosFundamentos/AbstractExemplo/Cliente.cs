using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplosFundamentos.AbstractExemplo
{
    public class Cliente : ClasseBase
    {
        public string Nome { get; set; }

        public string CPF { get; set; }


        public override string GerarIdentificador()
        {
            return CPF;
        }
    }
}