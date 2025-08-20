using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBiblioteca
{
    public class Program
    {
        private static Biblioteca novaBiblioteca = new Biblioteca();
        static void Main(string[] args)
        {
            // 9 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor.
            // Utilize o encapsulamento para garantir que o título e o autor não sejam vazios. 
            // Decide ir um pouco alem para reforçar as praticas dos outros exercicios tentando implementar um codigo melhor, menos repetitivo e melhorar algumas práticas.
             
            Menu(); 
 
        }

    public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("ESTANTE DE LIVROS");
            Console.WriteLine("\nO que deseja fazer?");
            Console.WriteLine("1 - Adicionar livro \n2 - Remover Livro \n3 - Listar livros \n \n0 - Sair da biblioteca");

            string escolha = Console.ReadLine();

            if (int.TryParse(escolha, out int opcao))
            {
                switch (opcao) {
                    case 1: novaBiblioteca.AdicionarLivro(); break;
                    case 2: novaBiblioteca.RemoverLivro(); break;
                    case 3: novaBiblioteca.ExibirEstante(); break;
                    case 0: System.Environment.Exit(0); break;
                }
            } else
            {
                Console.WriteLine("Digite somente números!");
                Menu();
            }
        }
    }


}

