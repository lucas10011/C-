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

namespace ValueRef
{
    public class PosicaoClass // reference type
    {
        public int X;
        public int Y;
    }

    class Program
    {
        public static void Dobrar(ref int valor)
        {
            valor = valor * 2;
        }

        public static void Dobrar(PosicaoClass valor)
        {
            valor.X = valor.X * 2;
            valor.Y = valor.Y * 2;
        }
        
        
        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;
            PosicaoClass pos2 = new PosicaoClass();
            pos2.X = 30;
            pos2.Y = 40;
            Dobrar(pos1);//nesse caso o valor de pos1 vai dobrar pq quando passo um reference type como parametro estou passando a sua posiçao na memoria,
            // e quando passo um value type o parametro se torna apenas uma copia do valor passado 
            Dobrar(pos2);
            Console.WriteLine(pos1.X);
            Console.WriteLine(pos1.Y);
            Console.WriteLine(pos2.X);
            Console.WriteLine(pos2.Y);
            Console.ReadLine();
        }

        private static void DobrarValue()
        {
            int x = 10;
            Dobrar(ref x);
            Console.WriteLine(x);
        }

        private static void RefTypeInt()
        {
            PosicaoClass pos1 = new PosicaoClass();//Reference Type
            pos1.X = 10;
            pos1.Y = 20;
            PosicaoClass pos2 = new PosicaoClass();//Reference Type
            pos2.X = 30;
            pos2.Y = 40;
            pos2 = pos1; // apontando ambos para a mesma posição de memória,
            pos2.X = 50;
            //Como apontei pos2 e pos1 para mesma posiçao de memoria, a propriedade x vai receber valor 50 em ambas
            Console.WriteLine(pos1.X);
            Console.WriteLine(pos1.Y);
            Console.WriteLine(pos2.X);
            Console.WriteLine(pos2.Y);
        }

        private static void ValueTypeInt()
        {
            int x = 10;
            int y = 20;
            y = x; // cópia
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
