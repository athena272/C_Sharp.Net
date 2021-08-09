using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF  { get; set; }
        public double Salario { get; protected set; }

        //SEMPRE QUE UM FUNCIONARIO É CRIADO, O Nº DE fUNCIONARIOS AUMENTA  
        public Funcionario(string cpf, double salario)
        {
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
            Console.WriteLine("Criando um(a) FUNCIONARIO(A)");
        }

        public abstract void AumentarSalario(); 

        public abstract double GetBonificacao();
    }
}
