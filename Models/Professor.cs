using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Professor : Pessoa // ninguem pode herdar professor
    {

       public Professor(string nome) : base(nome) // construtor feito por heranca
        {
            
        }

        public decimal Salario { get; set; }

                public sealed override void Apresentar()// override inidca metodo sobrescrito da classe mae && sealed que ele nao pode ser herdado e sobrescrito
        {
            Console.WriteLine($"Ola, me chamo {Nome} e tenho {Idade} anos e ganho salario {Salario}");
        }
    }
}