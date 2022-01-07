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

namespace PropriedadesIndexadas
{
    public class Produtos
    {
        private List<string> _itens;
        public Produtos()
        {
            this._itens = new List<string>();
        }
        public void Add(string item)
        {
            this._itens.Add(item);
        }
        public string Get(int index)
        {
            return this._itens[index];
        }
        // propriedade indexada
        public string this [int index]
        {
            get
            {
                //return this.Get(index);
                return this._itens[index];
            }
        }
        public int this [string nome]
        {
            get
            {
                return this._itens.IndexOf(nome);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var prods = new Produtos();
            prods.Add("iPhone");
            prods.Add("iPad");
            prods.Add("iPod");
            Console.WriteLine(prods[0]);
            Console.WriteLine(prods[1]);
            Console.WriteLine(prods[2]);
            Console.WriteLine("A posição do item iPad é " + prods["iPad"]);
            Console.ReadLine();
        }
    }
}
