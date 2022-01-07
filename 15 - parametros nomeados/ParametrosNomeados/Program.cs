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

namespace ParametrosNomeados
{
    public class DialogoBad
    {
        public void Show(string Mensagem, bool MostrarBotaoOk, bool MostrarBotaoNo, bool MostrarBotaoCancel, int Delay)
        {
            Console.WriteLine(Mensagem);
        }
    }

    public class Dialogo
    {
        public void Show(DialogoParams parametros)
        {
            Console.WriteLine(parametros.Mensagem);
        }
    }

    public class DialogoParams
    {
        public string Mensagem;
        public bool MostrarBotaoOk;
        public bool MostrarBotaoNo;
        public bool MostrarBotaoCancel;
        public int Delay;
        public bool Modal;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var Dlg1 = new DialogoBad();
            //string Mensagem = "Confirmar operação?";
            //bool MostrarBotaoOk = true;
            //bool MostrarBotaoNo = true;
            //bool MostrarBotaoCancel = false;
            //int Delay = 10;
            Dlg1.Show(
                Mensagem: "Confirmar operação?",
                MostrarBotaoOk: true, 
                Delay: 10, 
                MostrarBotaoNo: true, 
                MostrarBotaoCancel: false);
            var parametros = new DialogoParams()
            {
                Mensagem = "Confirmar operação?",
                MostrarBotaoOk = true,
                Delay = 10,
                MostrarBotaoNo = true,
                MostrarBotaoCancel = false,
                Modal = true
            };
            var dlg2 = new Dialogo();
            dlg2.Show(parametros: parametros);
            Console.ReadLine();
        }
    }
}
