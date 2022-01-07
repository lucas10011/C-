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
using System.Collections;

namespace HashTable
{
  public class Aluno
  {
    public int Matricula;
    public string Nome;
    public override string ToString()
    {
      return Matricula.ToString() + ":" + Nome; 
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      var alunos = new Hashtable();
      var a1 = new Aluno() { Matricula = 123, Nome = "Guinther" };
      var a2 = new Aluno() { Matricula = 456, Nome = "Rudolfo" };
      alunos.Add("123", a1);
      alunos.Add("456", a2);
      //Console.WriteLine((alunos["123"] as Aluno).Nome);
      //Console.WriteLine((alunos["456"] as Aluno).Nome);
      foreach (var obj in alunos.Values)
        Console.WriteLine(obj);
    }

    private static void CriaLista()
    {
      var lista = new Hashtable();
      lista.Add(1, "Guinther");
      lista.Add(2, "Rudolfo");
      lista.Add(3, "Fabio");
      if (lista.ContainsKey(3))
        Console.WriteLine(lista[3]);
      foreach (var obj in lista.Keys)
        Console.WriteLine(obj);
    }
  }
}
