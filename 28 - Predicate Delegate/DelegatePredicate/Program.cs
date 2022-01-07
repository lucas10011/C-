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

namespace DelegatePredicate
{
    class Program
    {
        public class Pessoa
        {
            public string Nome;
            public int Idade;
        }
        static void Main(string[] args)
        {
            List<Pessoa> Nomes = new List<Pessoa>() { 
                new Pessoa() { Nome = "Guinther", Idade = 35 },
                new Pessoa() { Nome = "Rudolfo", Idade = 34 },
                new Pessoa() { Nome = "Michael", Idade = 40 },
                new Pessoa() { Nome = "John", Idade = 45 },
                new Pessoa() { Nome = "Wesley", Idade = 30 }
            };
            //Predicate<Pessoa> pred = new Predicate<Pessoa>(Teste);
            Predicate<Pessoa> pred = new Predicate<Pessoa>(p => p.Idade >= 35);
            var lst = Nomes.FindAll(pred);
            foreach (var p in lst)
                Console.WriteLine(p.Nome);
            //foreach (var s in Nomes)
            //    if (Contains(s))
            //        Console.WriteLine(s);
            Console.ReadLine();
        }

        //public static bool Teste(Pessoa p)
        //{
        //    return p.Idade >= 35;
        //}
    }
}
