using ExemploPOO.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Bruno";
p1.Idade = 28;
p1.Apresentar();



ContaCorrente c1 = new ContaCorrente(1, 100M);
c1.ExibirSaldo();
c1.Sacar(50M);
Console.WriteLine("Apos o saque:");
c1.ExibirSaldo();
