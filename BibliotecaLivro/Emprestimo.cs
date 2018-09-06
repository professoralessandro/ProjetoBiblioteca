using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLivro
{
    class Emprestimo
    {
        #region ATRIBUTOS
        private DateTime dtEmprestimo;
        private DateTime dtDevolucao;
        #endregion

        #region CONSTRUTORES
        public Emprestimo(String dtEmprestimo, String dtDevolucao)
        {
            this.dtEmprestimo = DateTime.Parse(dtEmprestimo);
            this.dtDevolucao = DateTime.Parse(dtDevolucao);
        }
        public Emprestimo(String dtEmprestimo)
        {
            this.dtEmprestimo = DateTime.Parse(dtEmprestimo);
        }
        public Emprestimo()
        {
            this.dtEmprestimo = DateTime.Parse("01/03/2000 01:00");
            this.dtDevolucao = DateTime.Parse("01/03/2000 01:00");
        }
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
        public void setDtDevolucao(String dtDevolucao)
        {
            this.dtEmprestimo = DateTime.Parse(dtDevolucao);
        }

        public DateTime getDtDevolucao()
        {
            return this.dtDevolucao;
        }
        #endregion

        #region METODOS
        public override bool Equals(object obj)
        {
            Emprestimo p = (Emprestimo)obj;
            return this.dtEmprestimo.Equals(p.dtEmprestimo);
        }
        #endregion
    }
}
