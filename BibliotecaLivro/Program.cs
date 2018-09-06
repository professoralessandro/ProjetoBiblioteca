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
            Console.Clear();
            inicializar();
        }
        static void inicializar()
        {
            Console.Clear();
            Console.WriteLine("=======================================================================");
            Console.WriteLine("0. Sair");
            Console.WriteLine("1. Adicionar Livro");
            Console.WriteLine("2. Pesquisar livro (sinético)");
            Console.WriteLine("3. Pesquisar livro (analitico)");
            Console.WriteLine("4. Adicionar exemplar");
            Console.WriteLine("5. Registrar empréstimo");
            Console.WriteLine("6. Registrar devolução");
            Console.WriteLine("=======================================================================");
            

            Int32 opc = Convert.ToInt32(Console.ReadLine());
            
            Livros lvs = new Livros();
            Livro lv = new Livro();

            if (opc == 0)
            {
                Console.Out.Close();
            }
            else if(opc == 1)
            {
                Console.Clear();
                //Int32 tombo = 0;
                Int32 isbn = 0;
                String titulo = "";
                String autor = "";
                String editora = "";

                Console.WriteLine("Informe qual é o isbn");
                isbn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe qual é o titulo");
                titulo = Console.ReadLine();

                Console.WriteLine("Informe qual é o autor");
                autor = Console.ReadLine();

                Console.WriteLine("Informe qual é a editora");
                editora = Console.ReadLine();

                lvs.adicionar(new Livro(isbn, titulo, autor, editora));

                Console.Clear();
                inicializar();
            }//ELSE IF 1
            else if (opc == 2)
            {
                Console.Clear();

                Console.WriteLine(lvs.pesquisar());

                Console.WriteLine();

                Console.ReadKey();
                inicializar();
            }
            else if (opc == 3)
            {
                Console.Clear();
                Int32 isbn = 0;

                Console.WriteLine("Informe qual é o ISBN do livro");
                isbn = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(lvs.pesquisar(isbn));

                Console.WriteLine();

                Console.ReadKey();
                inicializar();
            }//else if 3
            else if (opc == 4)
            {
                Console.Clear();
                Int32 tombo = 0;
                //Int32 isbn = 0;
                //String titulo = "";
                //String autor = "";
                //String editora = "";

                Console.WriteLine("Informe qual é o Tombo do exemplar");
                tombo = Convert.ToInt32(Console.ReadLine());

                lv.adicionarExemplar(new Exemplar(tombo));

                Console.Clear();
                inicializar();
            }
            else if (opc == 5)
            {
                Console.WriteLine("Informe qual é o Tombo do exemplar");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
