using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBiblioteca
{
     class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }


        public Livro(string titulo, string autor) {
            // ao definir os titulos e os autores são nulos ou caracteres vazios, assim devolvendo o erro, só assim salvando. Pratica de encapsulamento e tratamento de erro, conforme pedido no exercico.
            if (string.IsNullOrWhiteSpace(titulo))
                throw new ArgumentNullException("O livro deve conter um título!");
            
            if (string.IsNullOrWhiteSpace(autor)) 
                throw new ArgumentNullException("O livro deve conter um autor!");

            Titulo = titulo;
            Autor = autor;
        }
    }


}
