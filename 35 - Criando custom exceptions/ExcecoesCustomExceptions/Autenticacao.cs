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

namespace ExcecoesCustomExceptions
{
    public class AutenticacaoException: Exception
    {
        public AutenticacaoException (string Message): base (Message)
        {

        }
    }

    public class UsuarioInvalidoException : AutenticacaoException
    {
        public UsuarioInvalidoException (string Message): base (Message)
        {

        }
    }

    public class SenhaInvalidaException : AutenticacaoException
    {
        public SenhaInvalidaException(string Message)
            : base(Message)
        {

        }

    }

    public static class Autenticacao
    {
        public static void Autenticar(string usuario, string senha)
        {
            if (usuario != "admin")
                throw new UsuarioInvalidoException("Usuário inválido!");
            if (senha != "admin")
                throw new SenhaInvalidaException("Senha inválida!");      
        }
    }
}
