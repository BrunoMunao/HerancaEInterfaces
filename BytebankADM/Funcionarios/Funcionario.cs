using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, double salario) 
        { 
            this.Nome = nome;
            this.CPF = cpf;
            this.Salario = salario;
        }    
        
        public double GetBonificacao() { return this.Salario * 0.1; }

        public void ExibeDados()
        {
            Console.WriteLine($"Nome: { this.Nome }");
            Console.WriteLine($"CPF: { this.CPF }");
            Console.WriteLine($"Salário: { this.Salario }");
            Console.WriteLine($"Bonificação: {this.GetBonificacao():F2}");
        }

    }
}
