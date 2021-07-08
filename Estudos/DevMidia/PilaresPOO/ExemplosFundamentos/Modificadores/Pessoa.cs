using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemplosFundamentos.Modificadores
{
    public class Pessoa
    {
        public string Nome { get; set; }

        protected int Idade { get; set; }

        private double Rendimento { get; set; }

        protected internal string Endereco { get; set; }

        internal string Estado { get; set; }
    }

}