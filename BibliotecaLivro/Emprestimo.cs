using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLivro
{
    class Emprestimo : Exemplar
    {
        #region ATRIBUTOS
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;
        #endregion

        #region PROPRIEDADES
        public void setDtEmprestimo(String dtEmprestimo)
        {
            this.dtEmprestimo = DateTime.Parse(dtEmprestimo);
        }

        public DateTime getDtEmprestimo()
        {
            return this.dtEmprestimo;
        }
        public void setDtDevolucao(DateTime dtDevolucao)
        {
            this.dtEmprestimo = dtDevolucao;
        }

        public DateTime getDtDevolucao()
        {
            return this.dtDevolucao;
        }
        #endregion

        #region CONSTRUTORES
        //construtores
        public Emprestimo(DateTime dtEmprestimo, DateTime dtDevolucao, Int32 isbn, Int32 tombo)
        {
            this.dtEmprestimo = dtEmprestimo;
            this.dtDevolucao = dtDevolucao;
            this.setIsbn(isbn);
            this.setTombo(tombo);
        }
        public Emprestimo(DateTime dtDevolucao, Int32 isbn, Int32 tombo)
        {
            this.dtDevolucao = dtDevolucao;
            this.setIsbn(isbn);
            this.setTombo(tombo);
        }
        public Emprestimo(DateTime dtEmprestimo)
        {
            this.dtEmprestimo = dtEmprestimo;
        }
        public Emprestimo()
        {
        }
        #endregion

        #region SOBREESCRITAS
        public override bool Equals(object obj)
        {
            Emprestimo p = (Emprestimo)obj;
            return this.dtEmprestimo.Equals(p.dtEmprestimo);
        }
        #endregion

        #region METODOS FUNCIONAIS
        public string dados()
        {
            return "ISBN: " + this.getIsbn() + " - tombo: "+ this.getTombo() + " - data do empréstimo: " + this.dtEmprestimo.ToString() + " - data da devolução: " + this.dtDevolucao.ToString();
        }
        #endregion
    }
}
