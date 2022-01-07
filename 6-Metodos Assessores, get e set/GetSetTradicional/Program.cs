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

namespace GetSet
{

    public class Conta
    {
        private string _cliente;
        private double _valor;
        public Conta(string nomeCliente)
        {
            this._cliente = nomeCliente;
        }
        public Conta()
        {
            
        }
        public string getCliente()
        {
            return this._cliente;
        }
        public void setCliente(string value)
        {
            //if value ...
            this._cliente = value;
        }
        public void Sacar(double valor)
        {
            this._valor = this._valor - valor;
        }
        public void Depositar(double valor)
        {
            this._valor = this._valor + valor;
        }
        public double getValor()
        {
            return this._valor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.setCliente("Guinther");
            c.Depositar(1000);
            c.Sacar(500);
            Console.WriteLine("Cliente: " + c.getCliente());
            Console.WriteLine("Saldo na data = " + c.getValor());
            Console.ReadLine();
        }
    }
}
