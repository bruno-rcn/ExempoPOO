using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora 
    {

        public int Dividir(int n1, int n2)
        {
            int total = n1 / n2;
            return total;
        }

        public int Multiplicar(int n1, int n2)
        {
            int total = n1 * n2;
            return total;
        }

        public int Somar(int n1, int n2)
        {
            int total = n1 + n2;
            return total;
        }

        public int Subtrair(int n1, int n2)
        {
            int total = n1 - n2;
            return total;
        }
    }
}