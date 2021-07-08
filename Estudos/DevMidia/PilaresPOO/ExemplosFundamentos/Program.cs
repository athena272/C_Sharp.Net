using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExemplosFundamentos.Heranca;

namespace ExemplosFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoaA = new PessoaFisica();
            Pessoa pessoaB = new PessoaJuridica();
            (pessoaA as PessoaFisica).CPF = "9999999";
            Console.WriteLine((pessoaA as PessoaFisica).CPF);
            Console.ReadLine();
        }
    }
}