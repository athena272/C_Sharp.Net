using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplosFundamentos.Heranca
{
    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public string InscricaoEstadual { get; set; }
    }
}