﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf) : base(nome, cpf, 5000)
        {
        }

        public override double GetBonificacao() { return this.Salario * 0.5 + base.GetBonificacao(); }

        public override void AumentaSalario()
        {
            this.Salario *= 1.15;
        }

    }
}
