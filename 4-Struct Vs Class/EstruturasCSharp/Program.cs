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

namespace EstruturasCSharp
{
    public class PosicaoClass: Object
    {
        public int X;
        public int Y;
        public override string ToString()
        {
            return "X = " + X.ToString() + ", Y = " + Y.ToString();
        }
    }

    public struct PosicaoStruct // Struct é uma classe que na verdade apresenta comportamento de um value type
    {
        public int X;
        public int Y;
        public override string ToString()
        {
            return "X = " + X.ToString() + ", Y = " + Y.ToString();
        }

    }

    public enum Role
    {
        Arquiteto, Developer, Tester
    }

    public enum Color
    {
        Red = 0, Green = 1, Blue = 2
    }

    public enum FormasPagto
    {
        Boleto, Cartao, Cheque
    }

    class Program
    {
        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();//new Posicao Struct, estou fazendo um novo apontamento pra memoria
            pos1.X = 10;
            pos1.Y = 20;
            PosicaoStruct pos2 = new PosicaoStruct(); //new Posicao Struct, estou fazendo um novo apontamento pra memoria
            pos2.X = 30;
            pos2.Y = 40;
            PosicaoStruct pos3 = pos2; // cópia, ou seja, quando digo que pos3 = pos2 ele copia toda estrutura de pos2 e coloca numa nova posiçao da memoria 
            //pq ele se comporta como value type
            pos3.Y = 50;
            FormasPagto formaPagto = FormasPagto.Boleto;
            Role role = Role.Arquiteto;
            Color cor = 0;
            Console.WriteLine(formaPagto);
            Console.WriteLine(role);
            Console.WriteLine(cor);
            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
            Console.WriteLine(pos3);
            Console.ReadLine();
        }
    }
}
