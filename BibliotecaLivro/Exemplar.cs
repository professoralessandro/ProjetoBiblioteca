﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLivro
{
    class Exemplar : Livro
    {
        #region ATRIBUTOS
        //Atributos
        private Int32 tombo;
        private List<Emprestimo> emprestimos;
        //LISTA DE EMPRESTIMOS

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

        #region CONSTRUTORES
        //CONSTRUTORES
        public Exemplar(Int32 tombo, Int32 isbn)
        {
            this.setIsbn(isbn);
            this.tombo = tombo;
        }
        public Exemplar(Int32 tombo)
        {
            this.tombo = tombo;
        }
        public Exemplar()
        {
            this.emprestimos = new List<Emprestimo>();
        }
        #endregion

        #region SOBREESCRITAS
        public override bool Equals(object obj)
        {
            Exemplar p = (Exemplar)obj;
            return this.tombo.Equals(p.tombo);
        }
        #endregion

        #region METODOS FUNCIONAIS
        //METODOS
        public string dados()
        {
            return "Tombo : " + this.tombo.ToString();
        }
        public Boolean emprestar(Emprestimo emprestimo)
        {
            Emprestimo empt = new Emprestimo();
            Boolean emprestado = false;

            if (empt.getDtEmprestimo() > Convert.ToDateTime("01/01/0001 01:01"))
            {
                emprestado = false;
            }
            else
            {
                emprestimos.Add(emprestimo);
                emprestado = true;
            }

            emprestado = true;

            return emprestado;
        }//emprestar
        public Boolean devolver(Emprestimo emprestimo)
        {
            //OBJETOS
            Emprestimo empt = new Emprestimo();

            //Variaveis
            Boolean devolvido = false;
            
            /*
            if(empt.getDtEmprestimo() > Convert.ToDateTime(0))
            {
                empt.setDtDevolucao(new Emprestimo("0","0",0,0));
                devolvido = true;
            }
            else
            {
                devolvido = false;
            }
            */
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
