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

namespace ClassesEstaticas
{
    public static class ConversorStatic
    {
        public static double CelsiusToFah(double temperatura)
        {
            return (temperatura * 9 / 5) + 32;
        }
        public static double FahToCelsius(double temperatura)
        {
            return (temperatura - 32) * 5 / 9;
        }
    }

    public class ConversorInstancia
    {
        public static double temperatura;

        public double CelsiusToFah()
        {
            return (temperatura * 9 / 5) + 32;
        }
        public double FahToCelsius()
        {
            return (temperatura - 32) * 5 / 9;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new ConversorInstancia();
            var c2 = new ConversorInstancia();
            ConversorInstancia.temperatura = 30; //essa variavel nao pertence a instancia da classe e sim a classe ConversorInstancia
		//e entao como vc mudou a variavel da classe, ambas as instancias c1 e c2 vao receber essa mudança pq é uma variavel estatica
		//o que é estatico é da classe e nao da instancia
		//ou seja quando vc tem uma classe estatica tudo tem q ser estatico e nao pode ter construtor
		
            var celsius = c1.CelsiusToFah();
            //ConversorInstancia.temperatura = 70;
            var fah = c1.FahToCelsius();
            Console.WriteLine("Celsius = " + celsius);
            Console.WriteLine("Fah = " + fah);
            Console.ReadLine();
        }

        private static void TesteClasseEstatica()
        {
            var temperatura = 35.0;
            temperatura = ConversorStatic.CelsiusToFah(temperatura);
            Console.WriteLine(temperatura);
        }
    }
}
