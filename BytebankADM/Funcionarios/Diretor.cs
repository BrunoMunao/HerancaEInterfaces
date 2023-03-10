using BytebankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Funcionarios
{
    public class Diretor : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public Diretor(string nome, string cpf, string senha) : base(nome, cpf, 5000)
        {
            this.Senha = senha;
        }

        public override double GetBonificacao() { return this.Salario * 0.5 + base.GetBonificacao(); }

        public override void AumentaSalario()
        {
            this.Salario *= 1.15;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }

    }
}
