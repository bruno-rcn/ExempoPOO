using ExemploPOO.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Bruno";
// p1.Idade = 28;
// p1.Apresentar();



// ContaCorrente c1 = new ContaCorrente(1, 100M);
// c1.ExibirSaldo();
// c1.Sacar(50M);
// Console.WriteLine("Apos o saque:");
// c1.ExibirSaldo();


// Aluno a1 = new Aluno("Ricardo");
// a1.Idade = 29;
// a1.Nota = 8.9;
// a1.Apresentar();


// Professor prof1 = new Professor("Camara");
// prof1.Idade = 30;
// prof1.Salario = 2000M;
// prof1.Apresentar();


// Corrente corrente = new Corrente();
// corrente.Creditar(500M);
// corrente.ExibirSaldo();
// corrente.Creditar(500M);
// corrente.ExibirSaldo();


// =====================================================================

// Desafio 1
// int n;
// int maior = 0;
// int posicao = 0;
// for(int i = 1; i <= 100 ; i++)
// {
//     n = Convert.ToInt32(Console.ReadLine());
//     if(n > maior)
//     {
//         maior = n;
//         posicao = i;     
//     } 
// }
// Console.WriteLine(maior);
// Console.WriteLine(posicao);



// Desafio 2
// double A, B, C;

//preencha a a leitura dos dados aqui
// A = double.Parse(Console.ReadLine());
// B = double.Parse(Console.ReadLine());
// C = double.Parse(Console.ReadLine());

// Console.WriteLine("MEDIA = " + String.Format("{0:0.0}", ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5)));
// Console.ReadKey();



// Desafio 3
//  int limit = int.Parse(Console.ReadLine());
// for (int i = 0; i < limit; i++) 
// {
//     string[] line = Console.ReadLine().Split(" ");
//     double X = double.Parse(line[0]);
//     double Y = double.Parse(line[1]);
//     if (Y == 0) {
//         Console.WriteLine("divisao impossivel");
//     } else {
//         double resultado = X / Y;
//         Console.WriteLine(resultado.ToString("F1")); // Mostra o resultado com 1 dígito após o ponto decimal
//     }
// }



// Desafio 4
// public class ItemMagico
// {
//     //TODO:  Crie a classe ItemMagico com os atributos nome, descrição e poder
//     public string Nome { get; set; }
//     public string Descricao { get; set; }
//     public int Poder { get; set; }

//     public ItemMagico(string nome, string descricao, int poder)
//     {
//         Nome = nome;
//         Descricao = descricao;
//         Poder = poder;
//     }
// }

// string nome = Console.ReadLine();


// string descricao = Console.ReadLine();


// int poder = int.Parse(Console.ReadLine());

// // Cria o item mágico
// ItemMagico item = new ItemMagico(nome, descricao, poder);

// // Imprime o item criado
// Console.WriteLine($"Item: {item.Nome}\nDescrição: {item.Descricao}\nPoder: {item.Poder}");


// Desafio 5
// public class Robo
// {
//     private string nome;
//     private string modelo;
//     private int anoFabricacao;

//     public Robo(string nome, string modelo, int anoFabricacao)
//     {
//         this.nome = nome;
//         this.modelo = modelo;
//         this.anoFabricacao = anoFabricacao;
//     }

//     public void ExibirInformacoes()
//     {
//         Console.WriteLine($"O robô {nome}, modelo {modelo}, foi fabricado em {anoFabricacao}.");
//     }
// }

//         string nome, modelo;
//         int ano;

//         nome = Console.ReadLine();
//         modelo = Console.ReadLine();
//         ano = int.Parse(Console.ReadLine());

//         Robo robo = new Robo(nome, modelo, ano);
//         robo.ExibirInformacoes();


// Desafio 6
// public enum Naipe { Paus = 0, Ouros = 1, Copas = 2, Espadas = 3 }
// public enum Valor { As = 1, Valete = 2, Dama = 3, Rei = 4 }

// public class Carta
// {
//     private Naipe naipe;
//     private Valor valor;

//     public Carta(Naipe n, Valor v)
//     {
//         naipe = n;
//         valor = v;
//     }

//     public Naipe GetNaipe()
//     {
//         return naipe;
//     }

//     public Valor GetValor()
//     {
//         return valor;
//     }
// }

//         // Input para escolher a carta desejada
//         int valorEscolhido, naipeEscolhido;
//         do
//         {
 
//             valorEscolhido = int.Parse(Console.ReadLine());
//         } while (valorEscolhido < 1 || valorEscolhido > 4);

//         do
//         {

//             naipeEscolhido = int.Parse(Console.ReadLine());
//         } while (naipeEscolhido < 0 || naipeEscolhido > 3);

//         // Criação da carta escolhida pelo usuário
//         Carta cartaEscolhida = new Carta((Naipe)naipeEscolhido, (Valor)valorEscolhido);

//         // Exibição da carta escolhida pelo usuário
//         string nomeValor = "", nomeNaipe = "";

//         switch (cartaEscolhida.GetValor())
//         {
//             case Valor.As:
//                 nomeValor = "Ás";
//                 break;
//             case Valor.Valete:
//                 nomeValor = "Valete";
//                 break;
//             case Valor.Dama:
//                 nomeValor = "Dama";
//                 break;
//             case Valor.Rei:
//                 nomeValor = "Rei";
//                 break;
//         }

//         switch (cartaEscolhida.GetNaipe())
//         {
//             case Naipe.Paus:
//                 nomeNaipe = "Paus";
//                 break;
//             case Naipe.Ouros:
//                 nomeNaipe = "Ouros";
//                 break;
//             case Naipe.Copas:
//                 nomeNaipe = "Copas";
//                 break;
//             case Naipe.Espadas:
//                 nomeNaipe = "Espadas";
//                 break;
//         }

//         Console.WriteLine($"Carta escolhida: {nomeValor} de {nomeNaipe}");