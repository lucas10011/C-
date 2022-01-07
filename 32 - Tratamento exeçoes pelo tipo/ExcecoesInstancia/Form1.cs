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
using System.Text;

namespace Excecoes
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void HandleException(Exception E)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Message:");
            sb.AppendLine(E.Message);
            sb.AppendLine("StackTrace:");
            sb.AppendLine(E.StackTrace);
            sb.AppendLine("TargetSite:");
            sb.AppendLine(E.TargetSite.Name);
            sb.AppendLine("Source:");
            sb.AppendLine(E.Source);
            sb.AppendLine("Data:");
            foreach (var v in E.Data.Values)
                sb.AppendLine(v.ToString());
            txtLog.Text = sb.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal peso = Convert.ToDecimal(txtPeso.Text);
                decimal altura = Convert.ToDecimal(txtAltura.Text);
                decimal imc = peso / (altura * altura);
                txtIMC.Text = imc.ToString();
            }
            catch (OverflowException E)
            {
                MessageBox.Show("Valor muito grande para peso / altura");
                HandleException(E);
            }
            catch (FormatException E)
            {
                MessageBox.Show("Informe valores corretos para peso / altura");
                E.Data.Add("Valores", txtPeso.Text + ";" + txtAltura.Text);
                HandleException(E);
            }
            catch(DivideByZeroException E)
            {
                MessageBox.Show("Altura não pode ser zero");
                HandleException(E);
            }
            catch (ArithmeticException E)
            {
                MessageBox.Show("Erro aritmético");
                HandleException(E);
            }
            catch (Exception E)
            {
                // tratar as mais genéricas por último
                MessageBox.Show("Não foi possível calcular o IMC");
                HandleException(E);
            }
            finally // sempre é executado
            {
                txtAltura.Clear();
                txtPeso.Clear();
            }
            // aqui
        }
    }
}
