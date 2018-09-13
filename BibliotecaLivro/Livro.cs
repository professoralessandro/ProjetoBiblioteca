using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLivro
{
    class Livro
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

        #region PROPRIEDADES

        //propriedades

        public List<Exemplar> Exemplares
        {
            get { return this.exemplares; }
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

        #region CONSTRUTORES

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
        #endregion

        #region SOBRESCRITAS
        public override bool Equals(object obj)
        {
            Livro p = (Livro)obj;
            return this.isbn.Equals(p.isbn);
        }
        #endregion

        #region METODOS FUNCIONAIS
        //METODOS

        public string dados()
        {
            return "ISBN: " + this.isbn.ToString() + " - titulo: " + this.titulo + " - autor: " +
                this.autor + " - editora: " + this.editora;
        }
        public void adicionarExemplar(Exemplar exemplar)
        {
            this.exemplares.Add(exemplar);
        }//adicionarExemplar
        public int qtdeExemplares()
        {
            return this.exemplares.Count();
        }//qtdeExemplares()

        //A COMPLETAR METODOS
        /*
        + qtdeDisponiveis(): int
        + qtdeEmprestimos(): int
        + percDisponibilidade(): double
        */
        #endregion
    }//CLASS
}//NAMESPACE
