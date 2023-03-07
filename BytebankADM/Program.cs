using BytebankADM.Bonificacao;
using BytebankADM.Funcionarios;

// Criação de Funcionários
Funcionario funcPedro = new Funcionario("Pedro Malazartes", "048.356.123-48", 1313.17);
Diretor dirRoberta = new Diretor("Roberta Silva", "035.456.443-55", 5239.48);

// Gerenciador de Bonificação
GerenciadorDeBonificacao gerenciadorBonus = new GerenciadorDeBonificacao();
gerenciadorBonus.CalculaTotalDeBonificacao(funcPedro);
gerenciadorBonus.CalculaTotalDeBonificacao(dirRoberta);

// Exebição dos dados
funcPedro.ExibeDados();
dirRoberta.ExibeDados();
Console.WriteLine("Total de bonificação dos funcionários: " + gerenciadorBonus.TotalDeBonificacao); 