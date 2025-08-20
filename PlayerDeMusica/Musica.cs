using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDeMusica
{
    public  class Musica
    {
        public string Nome { get; private set; }
        public string Autor { get; private set; }

        public Musica(string nome, string autor) {
            Nome = nome;
            Autor = autor;
        }
    }
}
