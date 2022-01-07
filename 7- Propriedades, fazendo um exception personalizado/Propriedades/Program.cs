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

namespace Propriedades
{
    public enum TipoAluno
    {
        Regular, Especial
    }
    public class Aluno
    {
        private int _matricula;
        private string _nome;
        private double _mensalidade;
        private TipoAluno _tipo;

        public int Matricula
        {
            get {
                return this._matricula; 
            }
            set { 
                this._matricula = value; 
            }
        } 

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }       

        public double Mensalidade
        {
            get { return _mensalidade; }
            set {
                if (value < 0)
                    throw new Exception("Valor da mensalidade não pode ser negativo");
                else
                    _mensalidade = value; 
            }
        }
        
        public TipoAluno Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.Matricula = 123;
            a.Nome = "Guinther";
            a.Mensalidade = -100;
            a.Tipo = TipoAluno.Regular;
            Console.ReadLine();
        }
    }
}
