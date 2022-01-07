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

namespace Delegacao
{
	//Nome do tipo do meu delegate
	//Olha qm quiser pagar pedido vai ter q pagar um valor
    public delegate void PagarEvent(double valor); 

    public class Pedido
    {
	//antes era um objeto que recebia a delegaçao, agora é um evento q vai receber a delegaçao e o tipo do delegate

        public event PagarEvent Pagar;

        public void Fechar(double valor)
        {
            // delegação...
	    //Chamo o evento pagar que vai apontar para um determinado método, e esse método vai ser injetado de fora
            this.Pagar(valor);
        }
    }
    
}
