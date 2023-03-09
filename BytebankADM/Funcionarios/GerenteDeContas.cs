using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string nome, string cpf) : base(nome, cpf, 4000)
        {
        }

        public override double GetBonificacao() { return this.Salario * 0.25 + base.GetBonificacao(); }

        public override void AumentaSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
