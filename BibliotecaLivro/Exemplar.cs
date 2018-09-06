using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLivro
{
    class Exemplar
    {
        #region ATRIBUTOS
        //Atributos
        private Int32 tombo;
        private List<Emprestimo> emprestimos;
        //LISTA DE EMPRESTIMOS

        #endregion

        #region CONSTRUTORES
        //CONSTRUTORES
        public Exemplar(Int32 tombo)
        {
            this.tombo = tombo;
        }
        public Exemplar()
        {
            this.emprestimos = new List<Emprestimo>();
        }
        #endregion

        #region PROPRIEDADES
        //PROPRIEDADES
        public List<Emprestimo> getEmprestimos()
        {
            return this.emprestimos;
        }
        public void setTombo(Int32 tombo)
        {
            this.tombo = tombo;
        }

        public Int32 getTombo()
        {
            return this.tombo;
        }
        #endregion

        #region METODOS
        //METODOS
        public string dadosExemplar()
        {
            return "Tombo : " + this.tombo.ToString();
        }
        public Boolean emprestar(Emprestimo dtEmprestimo)
        {
            Boolean emprestado = false;

            emprestimos.Add(dtEmprestimo);

            emprestado = true;

            return emprestado;
        }//emprestar
        public Boolean devolver(Emprestimo dtdevolucao)
        {
            Boolean devolvido = false;

            emprestimos.Add(dtdevolucao);

            devolvido = true;

            return devolvido;
        }//devolver
        public Boolean disponivel(Exemplar exemplar)
        {
            Emprestimo empres = new Emprestimo();

            Boolean disponivel = false;
            if (empres.getDtDevolucao() != null)
            {
                disponivel = true;
            }
            else
            {
                disponivel = false;
            }
            return disponivel;
        }//disponivel

        public Int32 qtdeEmprestimos()
        {
            Int32 tot = 0;
            foreach(Emprestimo qtde in getEmprestimos())
            {
                tot++;
            }
            return tot;
        }//qtdeEmprestimos
        #endregion
    }
}
