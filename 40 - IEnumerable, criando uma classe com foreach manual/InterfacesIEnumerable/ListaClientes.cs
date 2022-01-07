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

namespace InterfacesIEnumerable
{
    public class ListaClientes: IEnumerable
    {
        private List<string> _clientes = new List<string>();
        private int _index = 0;

        public void Add(string str)
        {
            this._clientes.Add(str);
            this._index = this._index + 1;
        }

        //public IEnumerable<string> getClientes()
        //{
        //    yield return this._clientes[0];
        //    yield return this._clientes[1];
        //    yield return this._clientes[2];
        //    yield return this._clientes[3];
        //}

        public IEnumerator GetEnumerator()
        {
            //foreach (string str in this._clientes)
            for (int i = 0; i < _index; i++ )
                yield return this._clientes[i]; // manter o estado, posição do índice
        }
    }
}
