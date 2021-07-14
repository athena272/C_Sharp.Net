using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemplosFundamentos.Modificadores;

namespace ExemplosFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Ricardo";
            pessoa.Estado = "RJ";
            pessoa.Endereco = "Rua XPTO";
        }
    }
}