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

namespace TypeInference_Dynamic
{
    public class Connection
    {
        public string ConnectionString;
        public void Conectar()
        {
            Console.WriteLine("Conectando...");
        }
        public void Fechar()
        {
            Console.WriteLine("Fechando...");
        }
    }

    public static class Fabrica
    {
        public static Connection CriarConnnection()
        {
            return new Connection();
        }
    }
    class Program
    {  

        static void Main(string[] args)
        {
            var str = "TESTE";
            var x = 10;
            dynamic v = "TESTE";
            var con = Fabrica.CriarConnnection();
            con.ConnectionString = "BANCO";
            con.Conectar();
            con.Fechar();
            Console.ReadLine();
        }
    }
}
