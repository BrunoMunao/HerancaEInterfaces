using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string nome, string cpf) : base(nome, cpf, 3000)
        {
        }

        public override double GetBonificacao() { return this.Salario * 0.17 + base.GetBonificacao(); }

        public override void AumentaSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
