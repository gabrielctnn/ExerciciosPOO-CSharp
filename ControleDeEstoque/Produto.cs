using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int QtdEstoque { get; private set; }



        public Produto(string nome, double preco, int qtdEstoque)
        {
            Nome = nome;
            Preco = preco;
            QtdEstoque = qtdEstoque;
        }
    }
}