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

namespace ParametrosSobrecarga
{
    public class CaixaDialogo
    {
        // default
        public void Show(string Mensagem)
        {
            Console.WriteLine(Mensagem);
        }

        public void Show(string Mensagem, int Delay)
        {
            // configuração do delay
            Show(Mensagem); // default
            //Console.WriteLine(Mensagem);
        }

        public void Show(string Mensagem, int Delay, bool ok, bool no)
        {
            // configuração do delay
            // configuração dos botões ok e no
            Show(Mensagem);
            //Console.WriteLine(Mensagem);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dlg1 = new CaixaDialogo();
            dlg1.Show("Confirmar?");
            var dlg2 = new CaixaDialogo();
            dlg2.Show("Excluir?",20);
            var dlg3 = new CaixaDialogo();
            dlg3.Show("Are you sure?", Delay: 10, ok: true, no: false);
            Console.ReadLine();
        }
    }
}
