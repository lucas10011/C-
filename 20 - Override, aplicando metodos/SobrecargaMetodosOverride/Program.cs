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

namespace SobrecargaMetodosOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo mp3 = new Musica() { Nome = "Dream Theater - Illumination Theory" };
            Arquivo doc = new DocumentoWord() { Nome = ".net Magazine - Artigo POO" };
            Arquivo img = new Imagem() { Nome = "Golden Gate Bridge" };
            Arquivo txt = new Txt() { Nome = "Lista de compras" };
            Windows windows = new Windows();
            windows.Add(mp3);
            windows.Add(doc);
            windows.Add(img);
            windows.Add(txt);
            windows.AbrirTodos();
            //windows.Abrir(mp3);
            //windows.Abrir(doc);
            //windows.Abrir(img);
            Console.ReadLine();
        }
    }
}
