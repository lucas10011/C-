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
using System.Data;

namespace ClassesExtensao
{
    public static class MyExtensions
    {
        public static void WriteJSON(this DataSet ds, string fileName)
        {   
            //_ds
            //...
        }

        public static string ToUrl(this string str)
        {
            return str = "http://" + str;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var ds = new DataSet();
            //ds.WriteXml("dados.xml");
            //ds.WriteJSON("dados.js");
            //ds.WriteXml("dados.xml");
            string url = "guintherpauli.blogspot.com";
            Console.WriteLine(url.ToUrl());
            Console.ReadLine();
        }
    }
}
