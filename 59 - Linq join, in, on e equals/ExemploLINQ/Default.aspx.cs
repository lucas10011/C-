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

    private static string[] obterTodosArquivosDotNet4()
    {
      return
        Directory.GetFiles(
          @"C:\Windows\Microsoft.NET\Framework\v4.0.30319",
          "*",
          SearchOption.AllDirectories
        );
    }

    protected void btnConsulta_Click(object sender, EventArgs e)
    {
      string[] arquivosDotNet4 = obterTodosArquivosDotNet4();
      
      var tamanhoTotaisPorPasta = from arquivo in arquivosDotNet4
                                  let infoArquivo = new FileInfo(arquivo)
                                  group infoArquivo by infoArquivo.DirectoryName into g
                                  select new
                                  {
                                    Pasta = g.Key,
                                    TamanhoTotalKB = g.Sum(ia => ia.Length) / 1024M
                                  };

      var query = from arquivo in arquivosDotNet4
                  let infoArquivo = new FileInfo(arquivo)
                  group infoArquivo by new
                  {
                    Pasta = infoArquivo.DirectoryName,
                    Extensao = infoArquivo.Extension.ToUpper()
                  }
                    into infoArquivosPorPastaExtensao
                    join tamanhoTotalPorPasta in tamanhoTotaisPorPasta // consulta anterior
                    on infoArquivosPorPastaExtensao.Key.Pasta
                    equals tamanhoTotalPorPasta.Pasta
                    into juncaoComTamanhoTotalKB
                    let tamanhoTotalKB = juncaoComTamanhoTotalKB.Single().TamanhoTotalKB
                    let tamanhoKB = infoArquivosPorPastaExtensao.Sum(ia => ia.Length) / 1024M
                    orderby infoArquivosPorPastaExtensao.Key.Pasta,
                      tamanhoKB descending
                    select new
                    {
                      infoArquivosPorPastaExtensao.Key.Pasta,
                      infoArquivosPorPastaExtensao.Key.Extensao,
                      NumeroArquivos = infoArquivosPorPastaExtensao.Count(),
                      TamanhoKB = tamanhoKB,
                      Porcentagem = 100 * (tamanhoKB / tamanhoTotalKB)
                    };
      GridView1.DataSource = query;
      GridView1.DataBind();
    }
}