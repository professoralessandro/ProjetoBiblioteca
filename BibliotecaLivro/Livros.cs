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
        public List<Livro> getAcervo()
        {
            return this.acervo;
        }
        #endregion
        //CONSTRUTOR
        public Livros()
        {
            this.acervo = new List<Livro>();
        }

        #region METODOS
        public void adicionar(Livro livro)
        {
            this.getAcervo().Add(livro);
        }//adicionarExemplar
        public String pesquisar(Int32 num)
        {
            String vazio = "Este livro nao existe";
            String result = "";
            foreach (Livro livrinho in getAcervo())
            {
                //if(ListaCont.MinhaLista.Equals(new Contato(Convert.ToInt32(textId.Text))));
                if (livrinho.Equals(new Livro(num)))
                {
                    vazio = livrinho.dadosLivro();
                    return result;
                    break;
                }
            }
            return vazio;
        }//adicionarExemplar
        public String pesquisar()
        {
            String vazio = "Este livro nao existe";
            String result = "";

            foreach (Livro livrinho in getAcervo())
            {
                result = livrinho.dadosLivro();
                return result;
            }
            return vazio;
        }//adicionarExemplar

        #endregion
    }
}
