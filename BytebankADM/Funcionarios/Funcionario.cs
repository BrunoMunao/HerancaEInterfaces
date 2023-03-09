using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Salario = salario;
            TotalDeFuncionarios++;
        }

        public virtual double GetBonificacao() { return this.Salario * 0.1; }

        public abstract void AumentaSalario();


        public void ExibeDados()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"CPF: {this.CPF}");
            Console.WriteLine($"Salário: {this.Salario:F2}");
            Console.WriteLine($"Bonificação: {this.GetBonificacao():F2}");
            Console.WriteLine();
        }

    }
}
