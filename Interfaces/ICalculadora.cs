using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora// caso implemente o comportamento de um metodo aqui ele nao precisa ser implementado em quem implemente
    {

        public void Teste()
        {
            Console.WriteLine("Esse metodo nao e obrigatorio ser implementado por ja ter codigo. Pode ser chamado direto");
        }

        int Somar(int n1, int n2);
        int Subtrair(int n1, int n2);
        int Multiplicar(int n1, int n2);
        int Dividir(int n1, int n2);
    }
}