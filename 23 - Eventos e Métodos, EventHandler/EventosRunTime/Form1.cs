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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosRunTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarButtonEmRuntime_Click(object sender, EventArgs e)
        {
            var bt = new Button();
            bt.Parent = this;
            this.Controls.Add(bt);
            bt.Text = "Clique aqui";
            bt.Location = new System.Drawing.Point(58, 80);
	    
	    //EventHandler, o seu metódo que responde a eventHandler tem q ter os parametros passados no delegate, tem que receber na assinatura do método o object sender e EvetArgs e
	    //ou seja bt_Click responde ao EventHandler, e no eventHandler no delegate tem parametros, entao o delegate é como se fosse um contrato onde que quiser ser um Click tem q passar aqueles parametros
	    //Delegate é um contrato entre o event e o método criado, ou seja, ele esta dizendo q vai trabalhar com um tipo passado no delegate
            bt.Click += new EventHandler(bt_Click); // apontando o evento para um método 
            bt.Click += delegate(object s, EventArgs ea)
                {
                    // método anônimo
                    MessageBox.Show("Ola Mundo!");
                };
            bt.Click += (s, ea) => MessageBox.Show("Hello world");
        }

        void bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola Mundo!");
        }
    }
}
