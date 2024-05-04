using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo; // nao pode ser alterado externamento. Apenas por metodos das class filhas

        public abstract void Creditar(decimal valor); // as class filhas irao implementar o comportamento do metodo

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo e: {saldo}");
        }
    }
}