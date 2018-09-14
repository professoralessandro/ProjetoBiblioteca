using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLivro
{
    class Livros
    {
        #region ATRIBUTOS
        private List<Livro> acervo;
        #endregion

        #region PROPRIEDADES
        public List<Livro> Acervo
        {
            get { return acervo; }
        }
        #endregion

        #region CONSTRUTOR
        //CONSTRUTOR
        public Livros()
        {
            this.acervo = new List<Livro>();
        }
        #endregion

        #region SOBREESCRITAS
        public override bool Equals(object obj)
        {
            Livros p = (Livros)obj;
            return this.acervo.Equals(p.acervo);
        }
        #endregion

        #region METODOS
        public string dados()
        {
            return "Isbn: " + this.acervo;
        }

        public void adicionar(Livro livro)
        {
            this.acervo.Add(livro);
        }//adicionarExemplar
        public Livro pesquisar(Int32 num)
        {
            foreach (Livro livrinho in acervo)
            {
                //if(ListaCont.MinhaLista.Equals(new Contato(Convert.ToInt32(textId.Text))));
                if (livrinho.Equals(new Livro(num)))
                {
                    return livrinho;
                    break;
                }
            }
            return new Livro();
        }//adicionarExemplar
        public Livro pesquisar()
        {
            String vazio = "Este livro nao existe";
            String result = "";

            foreach (Livro livrinho in acervo)
            {
                return livrinho;
            }
            return new Livro();
        }//adicionarExemplar

        #endregion
    }
}
