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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaMetodosOverride
{
    public abstract class Arquivo
    {
        public string Nome;
        public int Tamanho;
		
	//public abstract void Abrir()
	//public virtual void Abrir() => parcialmente abstrato, possui um procedimento comum a todos, permite que implemente parte na classe base e parte na classe que vai herdar
        public virtual void Abrir()
        {
            Console.WriteLine("Abrindo arquivo " + Nome);
        }
    }

    public class Musica : Arquivo
    {
        public override void Abrir()
        {
	    //quando eu dou um override eu anulo oq esta na classe base entao para acessar oq esta na classe base eu dou um base, 
	    //mas pra isso a classe tem q ser virtual
            base.Abrir();
            Console.WriteLine("Tocando música: " + Nome);
        }
    }
    public class DocumentoWord : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando documento do Word: " + Nome);
        }
    }
    public class Imagem : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Exibindo imagem: " + Nome);
        }
    }
    public class Txt : Arquivo
    {
        public override void Abrir()
        {
            base.Abrir();
            Console.WriteLine("Mostrando arquivo texto: " + Nome);
        }
    }
    public class Windows
    {
        private List<Arquivo> _arquivos;
        public Windows()
        {
            this._arquivos = new List<Arquivo>();
        }
        public void Add(Arquivo arquivo)
        {
            this._arquivos.Add(arquivo);
        }
        public void AbrirTodos()
        {
            foreach (Arquivo arquivo in _arquivos)
                Abrir(arquivo);
        }

        public void Abrir(Arquivo arquivo)
        {
	   //Esse abrir é da classe arquivo mas em tempo de execução é q ele vai tomar uma forma concreta de algum metodo sobrescrito pelo override
            arquivo.Abrir();
        }
    }
}
