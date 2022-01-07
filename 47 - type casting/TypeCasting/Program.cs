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

namespace TypeCasting
{
  public static class RelatorioPessoas
  {
    public static void Imprimir(Pessoa pessoa)
    {
      Console.WriteLine(pessoa.Nome);
      if (pessoa is PessoaJuridica)
      Console.WriteLine((pessoa as PessoaJuridica).CNPJ);
      if (pessoa is PessoaFisica)
        Console.WriteLine((pessoa as PessoaFisica).CPF);
      if (pessoa is Governo)
        Console.WriteLine((pessoa as Governo).Departamento);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      var pf = new PessoaFisica();
      pf.Nome = "Guinther";
      pf.CPF = "123";
      var pj = new PessoaJuridica();
      pj.Nome = "GPauli";
      pj.CNPJ = "1234";
      var g = new Governo();
      g.Nome = "Departamento de Justiça";
      g.Departamento = "Justiça";
      RelatorioPessoas.Imprimir(pj);
      RelatorioPessoas.Imprimir(pf);
      RelatorioPessoas.Imprimir(g);
    }
  }
}
