using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLivro
{
    class Program
    {
        static void Main(string[] args)
        {
            inicializar();
        }//Main
        static void inicializar()
        {
            #region INSTANCIAS DOS OBJETOS
            Livros livros = new Livros();
            Livro livro = new Livro();
            Exemplar exemplar = new Exemplar();
            #endregion
            Console.WriteLine("=======================================");
            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Pesquisar Livro (sintético)*");
            Console.WriteLine("3. Pesquisar Livro (analítico)**");
            Console.WriteLine("4. Adicionar exemplar");
            Console.WriteLine("5. Registrar empréstimo");
            Console.WriteLine("6. Registrar devolução");
            Console.WriteLine("=======================================");
            String opc = Console.ReadLine();

            Console.Clear();

            #region OPCAO 0
            if (opc == "0")
            {
                Console.Out.Close();
            }
            #endregion
            #region OPCAO 1
            else if (opc == "1")
            {
                //Variaveis
                Int32 isbn;
                String titulo;
                String autor;
                String editora;

                //Entrada
                Console.WriteLine("Informe qual é o ISBN do livro");
                isbn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe qual é o título do livro");
                titulo = Console.ReadLine();

                Console.WriteLine("Informe qual é o autor do livro");
                autor = Console.ReadLine();

                Console.WriteLine("Informe qual é a editora do livro");
                editora = Console.ReadLine();

                livros.adicionar(new Livro(isbn, titulo, autor, editora));

                Console.WriteLine("Livro adicionado com sucesso!");
                Console.Clear();
                inicializar();
            }
            #endregion
            else if (opc == "2")
            {

            }
            else if (opc == "3")
            {

            }
            else if (opc == "4")
            {
                //variaveis
                Int32 tombo;
                Int32 isbn;

                //ENTRADA
                Console.WriteLine("Informe qual é o Tombo do exemplar");
                tombo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe qual é o ISBN do livro");
                isbn = Convert.ToInt32(Console.ReadLine());
                //PROCESAMENTO
                livro.adicionarExemplar(new Exemplar(tombo, isbn));

                Console.WriteLine("Exemplar de livro adicionado com sucesso!");
                Console.Clear();
                inicializar();
            }
            else if (opc == "5")
            {
                DateTime data = System.DateTime.Now;
                Int32 isbn;
                Int32 tombo;

                Console.WriteLine("Informe qual é o ISBN do livro");
                isbn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe qual é o Tombo do exemplar");
                tombo = Convert.ToInt32(Console.ReadLine());

                exemplar.emprestar();

                if(exemplar.emprestar() == true)
                {
                    Console.WriteLine("Exemplar de livro emprestado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Erro emprestar o exemplar!");
                }

                
                Console.ReadKey();
                Console.Clear();
                inicializar();
            }
            else if (opc == "6")
            {
                DateTime dataEmprestimo = System.DateTime.Now;
                DateTime dataDevolucao = System.DateTime.Now;
                Int32 isbn;
                Int32 tombo;

                Console.WriteLine("Informe qual é o ISBN do livro");
                isbn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe qual é o Tombo do exemplar");
                tombo = Convert.ToInt32(Console.ReadLine());

                exemplar.devolver();

                if(exemplar.devolver() == true)
                {
                    Console.WriteLine("Exemplar de livro foi devolvido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Erro ao devolver o exemplar!");
                }

                Console.ReadKey();
                Console.Clear();
                inicializar();
            }
        }//inicializar
    }//Class
}//namespace
