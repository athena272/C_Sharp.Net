using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplosFundamentos.Heranca
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public string RG { get; set; }
    }
}