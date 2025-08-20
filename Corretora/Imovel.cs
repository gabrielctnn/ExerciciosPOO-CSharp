using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corretora
{
    public class Imovel
    {
        public string Endereco { get; private set; }
        public double Preco { get; private set; }
        public string Tipo { get; private set; }

        public Imovel(string endereco, double preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }

        public void AlterarPreco(double novoPreco)
        {
            Preco = novoPreco;
        }
    }
}
