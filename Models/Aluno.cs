using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar() // override inidca metodo sobrescrito da classe mae
        {
            Console.WriteLine($"Ola, me chamo {Nome} e tenho {Idade} anos e sou aluno nota {Nota}");
        }
    }
}