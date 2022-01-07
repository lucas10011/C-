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

namespace Interfaces
{
    interface IDBConnection
    {
        void Close();
        void Open();
    }

    interface ITransactional
    {
        void StartTransaction();
    }

    public abstract class DBConnection: IDBConnection
    {
        public string ConnectionString { get; set; }
        public virtual void Close()
        {
            Console.WriteLine("Fechando conexão...");
        }

        public virtual void Open()
        {
            Console.WriteLine("Abrindo conexão...");
            Console.WriteLine("Conectado a " + ConnectionString);
        }
    }

    public class SqlConnection : DBConnection
    {
        public override void Open()
        {
            base.Open();
            // código específico para SQL
        }
        public override void Close()
        {
            base.Close();
        }
    }

    public class OracleConnection: DBConnection
    {
        public override void Close()
        {
            base.Close();
        }

        public override void Open()
        {
            base.Open();
        }
    }
}
