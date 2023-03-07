using BytebankADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Bonificacao
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void CalculaTotalDeBonificacao(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonificacao();
        }
        public void CalculaTotalDeBonificacao(Diretor diretor)
        {
            this.TotalDeBonificacao += diretor.GetBonificacao();
        }
    }
}
