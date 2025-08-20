using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBiblioteca
{
    class Biblioteca
    {
        List<Livro> EstanteDeLivro = new List<Livro>();

        public void AdicionarLivro()
        {
            Console.Clear();
            Console.WriteLine("Qual livro deseja adicionar à biblioteca?");
            Console.WriteLine("Nome: ");
            string titulo = Console.ReadLine();
            Console.WriteLine($"\nQual autor de {titulo}?");
            string autor = Console.ReadLine();
            Livro livro = new Livro (titulo, autor);    
            EstanteDeLivro.Add(livro);
            Console.WriteLine("Livro adicionado!");
            Console.ReadKey();
            Program.Menu();
        }

        public void RemoverLivro()
        {
            Console.Clear();
            
            ExibirLivros();
            try
            {
                Console.WriteLine("\nQual livro deseja remover à biblioteca?");
                string escolha = Console.ReadLine();
                if (int.TryParse(escolha, out int livroEscolhido))
                {
                    EstanteDeLivro.RemoveAt(livroEscolhido - 1);
                    Console.WriteLine("\nLivro removido!");
                    Console.ReadKey();
                    Program.Menu();
                } else
                {
                    Console.WriteLine("Digite somente números!");
                    Program.Menu();
                }
                
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Livro escolhido inexistente ou inválido! Por favor digite somente um dos lviros listados.");
                RemoverLivro();
                Console.ReadKey();
                Program.Menu();
            }

        }

        public void ExibirLivros()
        {
            Console.Clear();
            if(EstanteDeLivro.Count != 0) 
            {
                Console.WriteLine("ESTANTE DE LIVROS");
                int contador = 1;
                foreach (Livro livro in EstanteDeLivro) 
                {
                    Console.WriteLine($"\n {contador}. {livro.Titulo} - {livro.Autor}");
                    contador++;
                }
            } else
            {
                Console.WriteLine("Estante vazia!");
                Console.ReadKey();
                Program.Menu();
            }
        }

        public void ExibirEstante()
        {
            Console.Clear();
            if (EstanteDeLivro.Count != 0)
            {
                Console.WriteLine("ESTANTE DE LIVROS");
                int contador = 1;
                foreach (Livro livro in EstanteDeLivro)
                {
                    Console.WriteLine($"\n {contador}. {livro.Titulo} - {livro.Autor}");
                    contador++;
                }
            }
            else
            {
                Console.WriteLine("Estante vazia!");
            }
            Console.ReadKey();
            Program.Menu();

        }
    }
}
