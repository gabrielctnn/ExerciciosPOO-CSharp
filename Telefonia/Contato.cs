using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonia
{
    public class Contato
    {
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}