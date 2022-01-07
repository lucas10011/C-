/*
Sobre o autor:
Guinther Pauli
Cursos Treinamentos Consultoria
Delphi Certified Professional - 3,5,6,7,2005,2006,Delphi Web,Kylix,XE
Microsoft Certified Professional - MCP,MCAD,MCSD.NET,MCTS,MCPD (C#, ASP.NET, Arquitetura)
Colaborador Editorial Revistas .net Magazine e ClubeDelphi
MVP (Most Valuable Professional)
Emails: guintherpauli@gmail.com / guinther@gpauli.com
http://www.gpauli.com
http://www.guintherpauli.blogspot.com.br
http://www.facebook.com/guintherpauli
http://www.twitter.com/guintherpauli
http://br.linkedin.com/in/guintherpauli
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    public class Filme
    {
        public string Nome;
        public int Ano;
    }

    public class Ator
    {
        public int Codigo;
        public string Nome;
        public List<Filme> Filmes;
        //public Ator(int codigo, string nome, string filme)
        //{
        //    this.Codigo = codigo;
        //    this.Nome = nome;
        //    this.Filme = filme;
        //}
        //public Ator(string nome)
        //{
        //    this.Nome = nome;
        //}
        //public Ator(int codigo)
        //{
        //    this.Codigo = codigo;
        //}
        //public Ator()
        //{

        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Ator a = new Ator()
            {
               Codigo = 10,
               Nome = "Michael",
               Filmes = new List<Filme>()
               {
                   new Filme() { Nome = "Prison Break", Ano = 2005 },
                   new Filme() { Nome = "Programa", Ano = 2013 }
               }
            }; 
        }
    }
}
