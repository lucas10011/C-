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

namespace DelegateFunc
{
    public class Produto
    {
        public int Id;
        public string Nome;
        public double Preco;
        public override string ToString()
        {
            return Id + "-" + Nome + "-" + Preco; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Func<Produto, Produto> func = new Func<Produto, Produto>(Teste);
            Func<Produto, bool> func = new Func<Produto, bool>(p => p.Preco >= 2000);
            List<Produto> prods = new List<Produto>()
            {
                new Produto() { Id = 1, Nome = "iPad", Preco = 2450.50 },
                new Produto() { Id = 2, Nome = "iPhone", Preco = 1500.00},
                new Produto() { Id = 3, Nome = "Google Glass", Preco = 2000.00},
                new Produto() { Id = 4, Nome = "Dream Theater DVD", Preco = 100}
            };
            foreach (var p in prods.Where(func))
                Console.WriteLine(p);
            //foreach (Produto p in prods)
            //    if (Teste(p) != null)
            //        Console.WriteLine(p.Nome);
            Console.ReadLine();
        }

        //public static Produto Teste(Produto p)
        //{
        //    if (p.Preco >= 2000)
        //        return p;
        //    else
        //        return null;
        //}
    }
}
