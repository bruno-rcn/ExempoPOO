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


Aluno a1 = new Aluno();
a1.Nome = "Ricardo";
a1.Idade = 29;
a1.Nota = 8.9;
a1.Apresentar();


Professor prof1 = new Professor();
prof1.Nome = "Camara";
prof1.Idade = 30;
prof1.Salario = 2000M;
prof1.Apresentar();