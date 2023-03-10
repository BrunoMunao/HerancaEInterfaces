using BytebankADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BytebankADM.Parceiros
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public ParceiroComercial(string senha)
        {
            this.Senha = senha;
        }
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
