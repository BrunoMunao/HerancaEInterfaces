using BytebankADM.Bonificacao;
using BytebankADM.Funcionarios;

// Tudo feito até a aula de classes ABSTRATAS
#region 
/*
// Criação de Funcionários
Funcionario funcPedro = new Funcionario("Pedro Malazartes", "048.356.123-48", 1313.17);
Diretor dirRoberta = new Diretor("Roberta Silva", "035.456.443-55", 5239.48);

// Gerenciador de Bonificação
GerenciadorDeBonificacao gerenciadorBonus = new GerenciadorDeBonificacao();
gerenciadorBonus.CalculaTotalDeBonificacao(funcPedro);
gerenciadorBonus.CalculaTotalDeBonificacao(dirRoberta);

// Aumento do Salário 

// Exebição dos dados
funcPedro.ExibeDados();
dirRoberta.ExibeDados();
Console.WriteLine("Total de bonificação dos funcionários: " + gerenciadorBonus.TotalDeBonificacao);
*/
#endregion

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
Designer ulisses = new Designer("Ulisses", "172.456.748-26");
Diretor roberta = new Diretor("Roberta", "478.456.222.23");
Auxiliar flavio = new Auxiliar("Flávio", "153.789.456-10");
GerenteDeContas edson = new GerenteDeContas("Edson", "398.159.145-72");

List<Funcionario> listaFuncionarios = new List<Funcionario>();
listaFuncionarios.Add(edson);
listaFuncionarios.Add(flavio);
listaFuncionarios.Add(roberta);
listaFuncionarios.Add(ulisses);


for (int i = 0; i < Funcionario.TotalDeFuncionarios; i++)
    listaFuncionarios[i].ExibeDados();


