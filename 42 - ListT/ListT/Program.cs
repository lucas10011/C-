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

namespace ListT
{
  public class Cliente: Object
  {
    public int Codigo;
    public string Nome;
    public string CPF;
    public override string ToString()
    {
      return Codigo.ToString() + " - " + Nome;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      var c1 = new Cliente() { Codigo = 123, Nome = "Guinther", CPF = "123" };
      var c2 = new Cliente() { Codigo = 234, Nome = "Rudolfo", CPF = "456" };
      var c3 = new Cliente() { Codigo = 456, Nome = "Fabio", CPF = "789" };
      var lista = new List<Cliente>() { c1, c2, c2 };
      //lista.Add(c1);
      //lista.Add(c2);
      //lista.Add(c3);
      // Console.WriteLine(lista[0].CPF);
      foreach (var item in lista)
        Console.WriteLine(item);
      var cli = lista.FirstOrDefault(c => c.CPF == "456");
      Console.WriteLine(cli.Nome);
    }
  }
}
