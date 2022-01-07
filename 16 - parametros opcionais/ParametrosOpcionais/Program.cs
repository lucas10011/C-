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

namespace ParametrosOpcionais
{
    public class CaixaDialogo
    {
        public void Show(
            string Mensagem, 
            bool Ok, 
            bool No,                        
            int Tam = 200,
            //bool Cancel = false,
            int Delay = 10)
        {
            Console.WriteLine(Mensagem);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dlg1 = new CaixaDialogo();
            dlg1.Show(Mensagem: "Confirmar?", Ok: true, No:true);
            var dlg2 = new CaixaDialogo();
            dlg2.Show(Mensagem: "Excluir?", Ok:true, No:true, Delay: 20);
            Console.ReadLine();
        }
    }
}
