using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflexao
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Carro);
            getPropriedades(t);
            Console.ReadLine();
        }

        private static void getPropriedades(Type t)
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Informações do tipo: " + t.Name);
            str.AppendLine("Nome completo: " + t.FullName);
            str.AppendLine("Namespace: " + t.Name);
            Type tBase = t.BaseType;
            if (tBase != null)
            {
                str.AppendLine("Tipo base: " + t.BaseType.Name);
            }
            MemberInfo[] membros = t.GetMembers();
            foreach (var m in membros)
            {
                str.AppendLine(m.MemberType + " " + m.Name);
            }
            Console.WriteLine(str);
        }

        private static void Exemplo3()
        {
            Type t = typeof(Carro);
            Console.WriteLine(t.FullName);
            Console.ReadLine();
        }

        private static void Exemplo2()
        {
            Type t = Type.GetType("Reflexao.Carro", false, true);
            Console.WriteLine(t.FullName);
            Console.ReadLine();
        }

        private static void Exemplo1()
        {
            Carro c = new Carro();
            Type t = c.GetType();
            Console.WriteLine(t.FullName);
            Console.ReadLine();
        }
    }
}
