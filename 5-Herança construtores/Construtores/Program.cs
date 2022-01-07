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

namespace Construtores
{
    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }

    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public Contato Contato;
        // padrão
        public Cliente()
        {
            this.Codigo = 0;
            this.Nome = "sem nome";
            this.Contato = new Contato();
        }
        // overloads
        public Cliente(int codigo)
        {
            this.Codigo = codigo;
            this.Nome = "sem nome";
            this.Contato = new Contato();
        }

        public Cliente(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Contato = new Contato();
        }

        public override string ToString()
        {
            return "Codigo: " + Codigo + ", Nome: " + Nome; 
        }
    }
// chamando construtor da classe base
    public class ClienteVIP: Cliente
    {
        public int Tempo;
        public ClienteVIP(int codigo, string nome)
            :base(codigo,nome) 
        {
            this.Tempo = 10;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Cliente cli1 = new Cliente();
            cli1.Codigo = 123;
            cli1.Nome = "Guinther";
            cli1.Contato.Tipo = "Telefone";
            cli1.Contato.Descricao = "99999999";

            Cliente cli2 = new Cliente(456);
            cli2.Nome = "Rudolfo";

            Cliente cli3 = new Cliente(789,"Fulano");

            Cliente cli4 = new ClienteVIP(123,"Beltrano");
 
            Console.WriteLine(cli1);
            Console.WriteLine(cli2);
            Console.WriteLine(cli3);
            Console.WriteLine(cli4);


            Console.ReadLine();
        }
    }
}
