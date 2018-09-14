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
            string opc;
            do
            {
                Livros livros = new Livros();
                Livro livro = new Livro();
                Exemplar exemplar = new Exemplar();

                #region INSTANCIAS DOS OBJETOS



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
                opc = Console.ReadLine();

                Console.Clear();

            #region OPCAO 1
            if (opc == "1")
                {
                    //Entrada
                    
                        //Variaveis
                        Int32 isbn;
                        String titulo;
                        String autor;
                        String editora;

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
                        
                        Console.ReadKey();
                }
                #endregion
                else if (opc == "2")
                {
                    livros.adicionar(new Livro(0, "0", "0", "0"));
                    livros.adicionar(new Livro(1, "1", "1", "1"));
                    livros.adicionar(new Livro(2,"2","2","2"));
                    Console.Clear();
                    foreach(Livro l in livros.Acervo)
                    {
                        Console.WriteLine(l.dados());
                    }
                    Console.WriteLine(livros.Acervo.Count());
                    Console.ReadKey();
                }
                else if (opc == "3")
                {
                    Console.WriteLine(livros.Acervo.Count());
                }
                else if (opc == "4")
                {
                    //variaveis
                    Int32 tombo;
                    Int32 isbn;

                    //ENTRADA
                    Console.WriteLine("Informe qual é o Tombo do exemplar");
                    tombo = Convert.ToInt32(Console.ReadLine());

                    //PROCESAMENTO
                    livro.adicionarExemplar(new Exemplar(tombo));

                    Console.WriteLine("Exemplar de livro adicionado com sucesso!");
                    Console.Clear();

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

                    if (exemplar.emprestar() == true)
                    {
                        Console.WriteLine("Exemplar de livro emprestado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Erro emprestar o exemplar!");
                    }


                    Console.ReadKey();
                    Console.Clear();

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

                    if (exemplar.devolver() == true)
                    {
                        Console.WriteLine("Exemplar de livro foi devolvido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Erro ao devolver o exemplar!");
                    }

                    Console.ReadKey();
                    Console.Clear();

                }
            }
            while (opc != "0");
       

    }//Main
        static void inicializar()
        {
        }
    }//Class
}//namespace
