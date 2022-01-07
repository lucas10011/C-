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

namespace ClassesGenericas
{
    public class Pilha<T>
    {
        int pos = 0;
        T[] itens = new T[100];
        public void Push(T item)
        {
            itens[pos] = item;
            pos++;
        }
        public T Pop()
        {
            pos--;
            return itens[pos];           
        }
    }

    public class Cliente
    {
        public int Codigo;
        public string Nome;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pilha<string>();
            p1.Push("teste1");
            p1.Push("teste2");
            var p2 = new Pilha<int>();
            p2.Push(10);
            p2.Push(20);
            var p3 = new Pilha<Cliente>();
            p3.Push(new Cliente() { Codigo = 1, Nome = "Guinther" });
            p3.Push(new Cliente() { Codigo = 2, Nome = "Rudolfo" });
            Cliente pessoa = p3.Pop();            
        }
    }
}
