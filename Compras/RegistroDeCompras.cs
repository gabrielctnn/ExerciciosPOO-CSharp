using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras
{
    internal class RegistroDeCompras
    {
        public string Produto { get; private set; }
        public double Preco { get; private set; }   
        public DateTime Data { get; private set; }
        public RegistroDeCompras(string produto, double preco, DateTime data) 
        {
            Produto = produto;
            Preco = preco;
            Data = data;
        }
    
    }
}
