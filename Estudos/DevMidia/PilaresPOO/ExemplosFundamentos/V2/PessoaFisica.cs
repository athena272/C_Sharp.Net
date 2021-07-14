using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemplosFundamentos.Modificadores;

namespace ExemplosFundamentos.V2
{
    public class PessoaFisica : Pessoa
    {
        private PessoaFisica()
        {

        }

        private PessoaFisica(string nome, int idade, string endereco, string estado)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Endereco = endereco;
            this.Estado = estado;
        }
    }
}