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
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnConsulta_Click(object sender, EventArgs e)
    {
      var query = from arquivo in Directory.GetFiles(@"c:\windows\system32")
                  let infoArquivo = new FileInfo(arquivo)
                  let tamanhoArquivoMB = infoArquivo.Length / 1024M / 1024M
                  where tamanhoArquivoMB > 1M &&
                    infoArquivo.Extension.ToUpper() == ".EXE"
                  orderby tamanhoArquivoMB
                  select new
                  {
                    Nome = infoArquivo.Name,
                    TamanhoMB = tamanhoArquivoMB
                  };
      GridView1.DataSource = query;
      GridView1.DataBind();
    }
}