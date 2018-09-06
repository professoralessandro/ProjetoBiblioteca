using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLivro
{
    class Livro : Exemplar
    {
        Livros empres = new Livros();

        #region ATRIBUTOS

        //ATRIBUTOS
        private Int32 isbn;
        private String titulo;
        private String autor;
        private String editora;
        private List<Exemplar> exemplares;

        #endregion

        #region CONSTRUTOR

        //CONSTRUTORES
        public Livro(Int32 isbn, String titulo, String autor, String editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
        }

        public Livro(Int32 isbn)
        {
            this.isbn = isbn;
        }
        public Livro()
        {
            this.exemplares = new List<Exemplar>();
        }
        public string dadosLivro()
        {
            return "Isbn : " + this.isbn.ToString() + " - titulo: " + this.titulo + " - autor: " +
                this.autor + " - editora: " + this.editora;
        }
        #endregion

        #region PROPRIEDADES

        //propriedades
        public List<Exemplar> getExemplares()
        {
            return this.exemplares;
        }

        public void setIsbn(Int32 isbn)
        {
            this.isbn = isbn;
        }

        public Int32 getIsbn()
        {
            return this.isbn;
        }
        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }

        public String getTitulo()
        {
            return this.titulo;
        }
        public void setAutor(String autor)
        {
            this.autor = autor;
        }

        public String getAutor()
        {
            return this.autor;
        }
        public void setEditora(String editora)
        {
            this.editora = editora;
        }

        public String getEditora()
        {
            return this.editora;
        }
        #endregion

        #region METODOS
        //METODOS
        public override bool Equals(object obj)
        {
            Livro p = (Livro)obj;
            return this.isbn.Equals(p.isbn);
        }
        public void adicionarExemplar(Exemplar exemplar)
        {
            this.exemplares.Add(exemplar);
        }//adicionarExemplar

        public Int32 qtdeExemplares(Exemplar exemplar)
        {
            Int32 tot = 0;
            foreach(Exemplar exemp in exemplares)
            {
                tot++;
            }
            return tot;
        }

        public Int32 qtdeDisponiveis()
        {
            Emprestimo empres = new Emprestimo();

            Int32 tot = 0;
            foreach (Exemplar exemp in exemplares)
            {
                if(empres.getDtDevolucao() != null)
                {
                    tot++;
                }
            }
            return tot;
        }

        public Int32 qtdeEmprestimos()
        {
            Int32 tot = 0;
            foreach (Emprestimo qtde in getEmprestimos())
            {
                    tot++;   
            }
            return tot;
        }//qtdeEmprestimos
        #endregion
        public Double percDisponibilidade()
        {
            return 0.00;
        }//emprestar
    }//CLASS
}//NAMESPACE
