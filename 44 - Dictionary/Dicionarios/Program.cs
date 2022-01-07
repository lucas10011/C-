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

namespace Dicionarios
{
  public class Pedido
  {
    public int CodPedido;
    public string Cliente;
    public double Valor;
  }
  class Program
  {
    static void Main(string[] args)
    {
      var pedidos = new Dictionary<int, Pedido>();
      var p1 = new Pedido() { CodPedido = 1, Cliente = "Guinther", Valor = 1234.56 };
      var p2 = new Pedido() { CodPedido = 2, Cliente = "Rudolfo", Valor = 3456.23 };
      var p3 = new Pedido() { CodPedido = 3, Cliente = "Fabio", Valor = 6789.01 };
      pedidos.Add(1, p1);
      pedidos.Add(2, p2);
      pedidos.Add(3, p3);
      Console.WriteLine("Nomes dos clientes que fizeram pedidos:");
      foreach (Pedido p in pedidos.Values)
        Console.WriteLine(p.Cliente);
      Console.WriteLine("Pedidos:");
      foreach (KeyValuePair<int, Pedido> kvp in pedidos)
        Console.WriteLine(kvp.Key + " = " + kvp.Value.Cliente);
      Console.WriteLine("Soma dos pedidos:");
      var valor = pedidos.Sum(p => p.Value.Valor);
      Console.WriteLine(valor.ToString());
    }
  }
}
